using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Abstract
{
    public interface ICategoryDal
    {
        Task InsertAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(Category category);

        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(Guid id);
    }
}
