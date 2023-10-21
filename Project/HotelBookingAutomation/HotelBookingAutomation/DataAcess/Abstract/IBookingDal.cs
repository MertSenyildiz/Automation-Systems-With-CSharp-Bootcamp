using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Abstract
{
    public interface IBookingDal
    {
        Task InsertAsync(Booking booking);
        Task DeleteAsync(Booking booking);
        Task UpdateAsync(Booking booking);
        Task<IEnumerable<Booking>> GetAllAsync();
        Task<Booking> GetByIdAsync(Guid id);
        Task<IEnumerable<Booking>> GetByRoomIdAsync(Guid roomId);

        Task<Booking> GetOverlappingAsync(Booking booking);
        Task<Booking> GetByRoomIdClosestDateAsync(Guid roomId, DateTime start, DateTime end);
        Task<IEnumerable<BookingWithRoomNoDto>> GetByCustomerIdAndDatesAsync(Guid customerId, DateTime startDate, DateTime endDate);
    }
}
