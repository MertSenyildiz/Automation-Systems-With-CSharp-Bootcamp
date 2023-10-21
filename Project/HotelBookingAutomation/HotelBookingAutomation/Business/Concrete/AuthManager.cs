using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.Core.Security.Hashing;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HotelBookingAutomation.Business.Concrete
{
    public class AuthManager:IAuthService
    {
        IUserService _userService;
        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> Login(UserToLoginDto userToLoginDto)
        {
            try
            {
               var user = await _userService.GetUserByUsernameAsync(userToLoginDto.Username);
                if (user != null)
                {
                    if (HashingTool.VerifyPasswordHash(userToLoginDto.Password, user.Password, user.PasswordSalt))
                        return user;
                }
                else
                {
                    throw new InvalidOperationException("Invalid Credentials");
                }
            }catch (Exception ex)
            {
               
            }
            return null;
        }

        public async Task Register(UserToRegisterDto userToRegisterDto)
        {
            try
            {
                var userToCheck = await _userService.GetUserByUsernameAsync(userToRegisterDto.Username);
                if (userToCheck == null)
                {
                    byte[] hash, salt;
                    HashingTool.CreatePasswordHash(userToRegisterDto.Password, out hash, out salt);
                    User user = new()
                    {
                        Email=userToRegisterDto.Email,
                        Username=userToRegisterDto.Username,
                        FirstName=userToRegisterDto.FirstName,
                        LastName=userToRegisterDto.LastName,
                        Address=userToRegisterDto.Address,
                        Phone=userToRegisterDto.Phone,
                        RoleID=userToRegisterDto.RoleID,
                        Password=hash,
                        PasswordSalt=salt
                    };
                    await _userService.InsertUserAsync(user);
                }
                else
                    throw new InvalidDataException();
                
            }catch(Exception ex)
            {

            }
        }

        public async Task UpdatePasswordAsync(UserPasswordToUpdateDto newPasswordUser)
        {
            using var scope = new TransactionScope();
            try
            {
                var user = await _userService.GetUserByIdAsync(newPasswordUser.ID);
                byte[] hash, salt;
                HashingTool.CreatePasswordHash(newPasswordUser.Password,out hash,out salt);
                user.Password = hash;
                user.PasswordSalt= salt;
                await _userService.UpdateUserAsync(user);
                scope.Complete();
            }catch (Exception ex)
            {
                scope.Dispose();
            }
            
        }
    }
}
