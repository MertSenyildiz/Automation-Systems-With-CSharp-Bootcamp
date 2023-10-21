using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Abstract
{
    public interface IRoomPriceDal
    {
        Task InsertAsync(RoomPrice roomPrice);
        Task UpdateAsync(RoomPrice roomPrice);
        Task DeleteAsync(RoomPrice roomPrice);

        Task<IEnumerable<RoomPrice>> GetAllAsync();
        Task<IEnumerable<RoomPricesWithDetailsDto>> GetAllWithDetailsAsync();
        Task<RoomPrice> GetByIdAsync(Guid id);
        Task<IEnumerable<RoomPrice>> GetByCategory(Guid categoryId);
        Task<IEnumerable<RoomPrice>> GetByCategoryAndOverlappingDatesAsync(Guid categoryId,DateTime start,DateTime end);

        Task<RoomPrice> GetOverlappingAsync(RoomPrice roomPrice);
    }
}
