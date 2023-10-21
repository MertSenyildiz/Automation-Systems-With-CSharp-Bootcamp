using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace HotelBookingAutomation.Business.Concrete
{
    public class BookingManager:IBookingService
    {
        IBookingDal _bookingDal;
        IRoomPriceService _roomPriceService;
        public BookingManager(IBookingDal bookingDal,IRoomPriceService roomPriceService)
        {
            _bookingDal = bookingDal;
            _roomPriceService=roomPriceService;
        }

        public async Task<decimal> CalculateBookingPrice(Booking booking,Category category)
        {
            List<RoomPrice> _roomPrices = await _roomPriceService.GetRoomPricesByCategoryAndOverlappingDatesAsync(category.ID,
                    booking.CheckInDate,
                    booking.CheckOutDate) as List<RoomPrice>;
            var indate = booking.CheckInDate;
            var outdate = booking.CheckOutDate;
            var days = (int)Math.Ceiling((outdate - indate).TotalDays);
            decimal cost = 0;
            int otherdays = 0;
            if (_roomPrices.Any())
            {
                foreach (var price in _roomPrices)
                {
                    if (indate >= price.StartDate && outdate <= price.EndDate)
                    {
                        otherdays = days;
                        cost = days * price.Price;
                    }
                    else if (indate >= price.StartDate && indate <= price.EndDate)
                    {
                        var otherday = (int)Math.Ceiling((indate - price.StartDate).TotalDays);
                        cost += otherday * price.Price;
                        otherdays += otherday;
                    }
                    else if (outdate >= price.StartDate && outdate <= price.EndDate)
                    {
                        var otherday = (int)Math.Ceiling((outdate - price.StartDate).TotalDays);
                        cost += otherday * price.Price;
                        otherdays += otherday;
                    }
                    else if (indate <= price.StartDate && outdate >= price.EndDate)
                    {
                        var otherday = (int)Math.Floor((price.EndDate - price.StartDate).TotalDays);
                        cost += otherday * price.Price;
                        otherdays += otherday;
                    }

                }
                if (days > otherdays)
                    cost += (days - otherdays) * category.BasePrice;
            }
            else
            {
                cost = category.BasePrice * days;
            }
            return cost==0?category.BasePrice:cost;
        }

        public async Task<bool> DeleteBookingAsync(Booking booking)
        {
            bool result = false;
            try
            {
                await _bookingDal.DeleteAsync(booking);
                result = true;
            }catch (Exception ex) { }
            return result;
        }

        public async Task<Booking> GetBookingById(Guid id)
        {
            try
            {
                return await _bookingDal.GetByIdAsync(id);
            }catch (Exception ex) { }
            return null;
        }

        public async Task<Booking> GetBookingByRoomId(Guid roomId, DateTime startDate, DateTime endDate)
        {
            try
            {
                return await _bookingDal.GetByRoomIdClosestDateAsync(roomId,startDate,endDate); 
            }catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<BookingWithRoomNoDto>> GetBookingsByCustomerIdAndDatesAsync(Guid customerId, DateTime start, DateTime end)
        {
            try{
                return await _bookingDal.GetByCustomerIdAndDatesAsync(customerId,start,end);
            }
            catch(Exception ex){ }
            return null;
        }

        public async Task<Booking> GetOverlappingBookingAsync(Booking booking)
        {
            try
            {
                return await _bookingDal.GetOverlappingAsync(booking); 
            }catch(Exception ex) {
                throw;
            }
        }

        public async Task<bool> InsertBookingAsync(Booking booking)
        {
            bool result = false;
            using var scope = new TransactionScope();
            try
            {
                var overlapping = await GetOverlappingBookingAsync(booking);
                if (overlapping != null)
                {
                    throw new Exception();
                }
                await _bookingDal.InsertAsync(booking);
                result = true;
                scope.Complete();
            }
            catch (Exception ex) { }
            return result;
        }

        public async Task<bool> UpdateBookingAsync(Booking booking)
        {
            bool result = false;
            try
            {
                await _bookingDal.UpdateAsync(booking);
                result = true;
            }
            catch (Exception ex) { }
            return result;
        }
    }
}
