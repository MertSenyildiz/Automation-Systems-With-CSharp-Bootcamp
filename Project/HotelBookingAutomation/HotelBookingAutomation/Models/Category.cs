using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Models
{
    public class Category
    {

        [Column("id")]
        public Guid ID { get; set; }=Guid.NewGuid();

        [Column("category_name")]
        public string CategoryName { get; set; }

        [Column("base_price")]
        public decimal BasePrice { get; set; }
    }
}
