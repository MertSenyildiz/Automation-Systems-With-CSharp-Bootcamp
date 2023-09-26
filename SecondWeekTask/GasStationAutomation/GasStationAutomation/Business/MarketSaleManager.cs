using GasStationAutomation.DataAccess;
using GasStationAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStationAutomation.Business
{
    public class MarketSaleManager
    {
        MarketSaleDal _marketSaleDal;
        public MarketSaleManager()
        {
            _marketSaleDal = new MarketSaleDal();
        }

        public void AddMarketSale(MarketSale marketSale)
        {
            _marketSaleDal.Add(marketSale);
        }

        public double TotalRevenue()
        {
            var result = _marketSaleDal.GetAll().Sum(s => s.Sale);
            return result;
        }
        public IEnumerable<MarketSale> TotalRevenueByDate(DateTime start, DateTime end)
        {
            var result = _marketSaleDal.GetSalesByDate(start, end)
                .GroupBy(s => s.SaleDate.Date)
                .Select(g => new MarketSale { SaleDate = g.Key, Sale = g.Sum(a => a.Sale) });
            return result;
        }

        public IEnumerable<MarketSale> GetAllSales()
        {
            return _marketSaleDal.GetAll();
        }
    }
}
