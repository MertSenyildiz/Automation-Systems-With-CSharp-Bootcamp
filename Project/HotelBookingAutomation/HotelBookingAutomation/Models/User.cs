using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public Guid ID { get; set; }=Guid.NewGuid();

        [Column("username")]
        public string Username { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("role_id")]
        public Guid RoleID { get; set; }

        [Column("password")]
        public byte[] Password { get; set; }

        [Column("password_salt")]
        public byte[] PasswordSalt { get; set; }
    }
}
