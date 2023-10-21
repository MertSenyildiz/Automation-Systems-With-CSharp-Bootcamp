using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Abstract
{
    public interface IUserDal
    {
        Task InsertAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);

        Task<User> GetByIdAsync(Guid id);
        Task<List<User>> GetAllAsync();
        Task<User> GetByUsernameAsync(string username);

        Task<IEnumerable<UserWithAllDetailsDto>> GetAllWithDetailsAsync();

        Task<IEnumerable<UserWithAllDetailsDto>> GetAllWithDetailsBySearchTermAsync(string searchTerm);
    }
}
