using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Abstract
{
    public interface IRoomDal
    {
        Task InsertAsync(Room room);
        Task UpdateAsync(Room room);
        Task DeleteAsync(Room room);
        Task<IEnumerable<Room>> GetAllAsync();
        Task<IEnumerable<RoomWithDetailsDto>> GetAllWithDetailsAsync();
        Task<Room> GetByIdAsync(Guid id);
        Task<IEnumerable<RoomWithDetailsDto>> GetAllAvailableAsync(DateTime startDate, DateTime endDate);

        Task<Room> GetByUniqueNoAsync(string uniqueRoomNo);
        Task<IEnumerable<RoomWithDetailsDto>> GetAllBookedAsync(DateTime startDate, DateTime endDate);
    }
}
