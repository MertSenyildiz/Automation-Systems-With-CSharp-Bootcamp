using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Models
{
    public class Room
    {
        [Column("id")]
        public Guid ID { get; set; }= Guid.NewGuid();

        [Column("floor")]
        public int Floor { get; set; }

        [Column("room_no")]
        public int RoomNo { get; set; }

        [Column("unique_room_no")]
        public string UniqueRoomNo { get; set; }

        [Column("category_id")]
        public Guid CategoryID { get; set; }
    }
}
