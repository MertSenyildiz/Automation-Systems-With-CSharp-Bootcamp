using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.Core.Security.Hashing;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HotelBookingAutomation.Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task DeleteUserAsync(User user)
        {
            try
            {
                await _userDal.DeleteAsync(user);
            }catch (Exception ex) { }
        }

        public async Task<IEnumerable<UserWithAllDetailsDto>> GetAllUsersWithDetailsAsync()
        {
            try
            {

                return await _userDal.GetAllWithDetailsAsync();

            }catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<UserWithAllDetailsDto>> GetAllUsersWithDetailsBySearchTermAsync(string searchTerm)
        {
            try
            {

                return await _userDal.GetAllWithDetailsBySearchTermAsync(searchTerm);

            }
            catch (Exception ex) { }
            return null;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            try
            {
                return await _userDal.GetByIdAsync(id);
            }catch (Exception ex) {
                throw;
            }
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _userDal.GetByUsernameAsync(username);
        }

        public async Task InsertUserAsync(User user)
        {
            try
            {
               
                await _userDal.InsertAsync(user);
               
            }catch (Exception ex)
            {
                throw;
            }
        }

        public async Task UpdateUserAsync(User user)
        {
            try { 
                await _userDal.UpdateAsync(user);
            }catch (Exception ex) {
                throw;
            }
        }

        // Transaction Example
        //public async Task InsertUserAsync()
        //{
        //    using var scope = new TransactionScope();
        //    try
        //    {
        //        byte[] passwordSalt, passwordHash;
        //        HashingTool.CreatePasswordHash("Mert.123",out passwordHash,out passwordSalt);
        //        var user = new User
        //        {
        //            Email = "mert.senyildiz@project.com",
        //            FirstName="Mert",
        //            LastName="Şenyıldız",
        //            Username="Mert.Senyildiz",
        //            Password=passwordHash,
        //            PasswordSalt=passwordSalt,
        //        };
        //        await InsertUserAsync(user);
        //        scope.Complete();
        //    }catch(Exception ex) { }
        //}
    }
}
