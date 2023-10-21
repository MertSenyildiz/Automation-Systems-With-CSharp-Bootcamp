using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Models
{
    public class RoomPricesWithDetailsDto
    {
        [Column("id")]
        public Guid ID { get; set; } = Guid.NewGuid();

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("category_name")]
        public string CategoryName { get; set; }
    }
}
