using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Models
{
    public class Role
    {
        [Column("id")]
        public Guid ID { get; set; }

        [Column("role_name")]
        public string RoleName { get; set; }
    }
}
