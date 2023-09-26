using GasStationAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.DataAccess
{
    public class GasSaleDal
    {
        public IEnumerable<GasSale> GetAll()
        {
            using var context = new DbContext();
            return context.GetAll<GasSale>();
        }
        public void Add(GasSale gasSale)
        {
            using var context = new DbContext();
            context.Add(gasSale);
        }
        public IEnumerable<GasSale> GetSalesByDate(DateTime start,DateTime end)
        {
            using var context = new DbContext();
            var result= context.GetAll<GasSale>().Where(s=>s.SaleDate>=start && s.SaleDate<=end);
            return result;
        }
    }
}
