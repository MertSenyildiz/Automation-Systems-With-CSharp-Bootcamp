using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Abstract
{
    public interface IRoomService
    {
        Task InsertRoomAsync(Room room);
        Task DeleteRoomAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task<IEnumerable<Room>> GetAllRoomsAsync();
        Task<IEnumerable<RoomWithDetailsDto>> GetAllRoomsWithDetailsAsync();
        Task<IEnumerable<RoomWithDetailsDto>> GetAllAvailableRoomsAsync(DateTime start, DateTime end);
        Task<Room> GetRoomByIdAsync(Guid id);
        Task<Room> GetRoomByUniqueRoomNo(String uniqueRoomNo);
        Task<IEnumerable<RoomWithDetailsDto>> GetAllBookedRoomsAsync(DateTime start, DateTime end);
    }
}
