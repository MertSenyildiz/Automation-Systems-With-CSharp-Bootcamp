using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Models
{
    public class Customer
    {
        [Column("id")]
        public Guid ID { get; set; }= Guid.NewGuid();

        [Column("phone")]
        public string Phone { get; set; }

        [Column("id_no")]
        public string IDNo { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("zip_code")]
        public string ZipCode { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }
    }
}
