using GasStationAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.DataAccess
{
    public class ProductDal
    {
        public IEnumerable<Product> GetAll()
        {
            using var context = new DbContext();
            return context.GetAll<Product>();
        }
    }
}
