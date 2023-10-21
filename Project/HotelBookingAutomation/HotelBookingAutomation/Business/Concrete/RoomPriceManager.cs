using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HotelBookingAutomation.Business.Concrete
{
    public class RoomPriceManager:IRoomPriceService
    {
        IRoomPriceDal _roomPriceDal;
        public RoomPriceManager(IRoomPriceDal roomPriceDal)
        {
            _roomPriceDal = roomPriceDal;
        }

        public async Task DeleteOldInsertNewAsync(RoomPrice oldPrice, RoomPrice newPrice)
        {
            using var scope = new TransactionScope();
            try
            {
                await _roomPriceDal.DeleteAsync(oldPrice);
                await _roomPriceDal.InsertAsync(newPrice);
                scope.Complete();
            }catch (Exception ex) { }
        }

        public async Task DeleteRoomPriceAsync(RoomPrice roomPrice)
        {
            try
            {
                await _roomPriceDal.DeleteAsync(roomPrice);
            }catch (Exception ex) { }
        }

        public async Task<IEnumerable<RoomPrice>> GetAllRoomPricesAsync()
        {
            try
            {
                return await _roomPriceDal.GetAllAsync();
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<RoomPrice>> GetAllRoomPricesByCategoryAsync(Guid categoryId)
        {
            try
            {
                return await _roomPriceDal.GetByCategory(categoryId);
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<RoomPricesWithDetailsDto>> GetAllRoomPricesWithDetailsAsync()
        {
            try
            {
                return await _roomPriceDal.GetAllWithDetailsAsync();
            }catch (Exception ex) { }
            return null;
        }

        public async Task<RoomPrice> GetOverlappingRoomPriceAsync(RoomPrice roomPrice)
        {
            try
            {
                return await _roomPriceDal.GetOverlappingAsync(roomPrice);
            }catch (Exception ex) { }
            return null;
        }

        public async Task<RoomPrice> GetRoomPriceByIdAsync(Guid id)
        {
            try
            {
                return await _roomPriceDal.GetByIdAsync(id);
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<RoomPrice>> GetRoomPricesByCategoryAndOverlappingDatesAsync(Guid categoryId, DateTime startDate, DateTime endDate)
        {
            try
            {
                return await _roomPriceDal.GetByCategoryAndOverlappingDatesAsync(categoryId,startDate,endDate);
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task InsertRoomPriceAsync(RoomPrice roomPrice)
        {
            try
            {
                await _roomPriceDal.InsertAsync(roomPrice);
            }
            catch (Exception ex) { }
        }

        public async Task UpdateRoomPriceAsync(RoomPrice roomPrice)
        {
            try
            {
                await _roomPriceDal.UpdateAsync(roomPrice);
            }
            catch (Exception ex) { }
        }
    }
}
