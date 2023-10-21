using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Models
{
    public class Booking
    {
        [Column("id")]
        public Guid ID { get; set; }=Guid.NewGuid();

        [Column("customer_id")]
        public Guid CustomerID { get; set; }

        [Column("room_id")]
        public Guid RoomID { get; set; }

        [Column("check_in_date")]
        public DateTime CheckInDate { get; set; }

        [Column("check_out_date")]
        public DateTime CheckOutDate { get; set; }

        [Column("total_price")]
        public decimal TotalPrice { get; set; }
    }
}
