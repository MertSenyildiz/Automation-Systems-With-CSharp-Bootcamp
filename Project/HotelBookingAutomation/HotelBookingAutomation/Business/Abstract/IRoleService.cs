using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Abstract
{
    public interface IRoleService
    {
        Task InsertRoleAsync(Role role);

        Task<List<Role>> GetAllRoles();

        Task UpdateRoleAsync(Role role);

        Task DeleteRoleAsync(Role role);
    }
}
