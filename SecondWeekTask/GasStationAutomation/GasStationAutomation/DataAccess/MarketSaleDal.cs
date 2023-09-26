using GasStationAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.DataAccess
{
    public class MarketSaleDal
    {
        public IEnumerable<MarketSale> GetAll()
        {
            using var context = new DbContext();
            return context.GetAll<MarketSale>();
        }
        public void Add(MarketSale marketSale)
        {
            using var context = new DbContext();
            context.Add(marketSale);
        }
        public IEnumerable<MarketSale> GetSalesByDate(DateTime start, DateTime end)
        {
            using var context = new DbContext();
            var result = context.GetAll<MarketSale>().Where(s => s.SaleDate >= start && s.SaleDate <= end);
            return result;
        }
    }
}
