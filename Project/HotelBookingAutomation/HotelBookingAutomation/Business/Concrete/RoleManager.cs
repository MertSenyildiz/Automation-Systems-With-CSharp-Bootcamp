using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Concrete
{
    public class RoleManager:IRoleService
    {
        IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public async Task DeleteRoleAsync(Role role)
        {
            try
            {
                await _roleDal.DeleteAsync(role);
            }
            catch (Exception ex) { }
        }

        public async Task<List<Role>> GetAllRoles()
        {
            List<Role> roles = null;
            try
            {
                
                roles= await _roleDal.GetAllAsync() as List<Role>;

            }catch (Exception ex) { }
            return roles;
        }

        public async Task InsertRoleAsync(Role role)
        {
            role.ID=Guid.NewGuid();
            try
            {
                await _roleDal.InsertAsync(role);
            }
            catch (Exception ex) { }
        }

        public async Task UpdateRoleAsync(Role role)
        {
            try
            {
                await _roleDal.UpdateAsync(role);
            }catch(Exception ex) { }
        }
    }
}
