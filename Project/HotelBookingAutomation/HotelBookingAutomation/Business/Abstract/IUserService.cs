using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Abstract
{
    public interface IUserService
    {
        Task InsertUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task<User> GetUserByUsernameAsync(string username);

        Task<IEnumerable<UserWithAllDetailsDto>> GetAllUsersWithDetailsAsync();

        Task<IEnumerable<UserWithAllDetailsDto>> GetAllUsersWithDetailsBySearchTermAsync(string searchTerm);
        Task<User> GetUserByIdAsync(Guid id);
        
    }
}
