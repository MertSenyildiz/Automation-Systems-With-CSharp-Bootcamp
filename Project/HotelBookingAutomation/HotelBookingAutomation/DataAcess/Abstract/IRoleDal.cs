using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Abstract
{
    public interface IRoleDal
    {
        Task InsertAsync(Role role);

        Task<IEnumerable<Role>> GetAllAsync();

        Task UpdateAsync(Role role);

        Task DeleteAsync(Role role);
    }
}
