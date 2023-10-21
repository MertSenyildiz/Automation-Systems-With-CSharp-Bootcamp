using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Abstract
{
    public interface IRoomPriceService
    {
        Task InsertRoomPriceAsync(RoomPrice roomPrice);
        Task UpdateRoomPriceAsync(RoomPrice roomPrice);
        Task DeleteRoomPriceAsync(RoomPrice roomPrice);
        Task DeleteOldInsertNewAsync(RoomPrice oldPrice,RoomPrice newPrice);
        Task<RoomPrice> GetRoomPriceByIdAsync(Guid id);
        Task<IEnumerable<RoomPrice>> GetAllRoomPricesAsync();
        Task<RoomPrice> GetOverlappingRoomPriceAsync(RoomPrice roomPrice);

        Task<IEnumerable<RoomPrice>> GetRoomPricesByCategoryAndOverlappingDatesAsync(Guid categoryId, DateTime startDate,DateTime endDate);
        Task<IEnumerable<RoomPricesWithDetailsDto>> GetAllRoomPricesWithDetailsAsync();
        Task<IEnumerable<RoomPrice>> GetAllRoomPricesByCategoryAsync(Guid categoryId);
    }
}
