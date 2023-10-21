using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Abstract
{
    public interface IAuthService
    {
        Task<User> Login(UserToLoginDto userToLoginDto);
        Task Register(UserToRegisterDto userToRegisterDto);
        Task UpdatePasswordAsync(UserPasswordToUpdateDto newPasswordUser);
    }
}
