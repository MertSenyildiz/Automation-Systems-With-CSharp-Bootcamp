using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Models
{
    public class UserPasswordToUpdateDto
    {
        public Guid ID { get; set; }
        public string Password { get; set; }
    }
}
