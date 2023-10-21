using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Abstract
{
    public interface IBookingService
    {
        Task<bool> InsertBookingAsync(Booking booking);
        Task<bool> UpdateBookingAsync(Booking booking);
        Task<bool> DeleteBookingAsync(Booking booking);
        Task<decimal> CalculateBookingPrice(Booking booking,Category category);
        Task<Booking> GetOverlappingBookingAsync(Booking booking);
        Task<Booking> GetBookingByRoomId(Guid roomId, DateTime start, DateTime end);
        Task<IEnumerable<BookingWithRoomNoDto>> GetBookingsByCustomerIdAndDatesAsync(Guid customerId, DateTime start, DateTime end);
        Task<Booking> GetBookingById(Guid id);
    }
}
