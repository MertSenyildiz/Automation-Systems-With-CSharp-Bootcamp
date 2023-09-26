using GasStationAutomation.DataAccess;
using GasStationAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.Business
{
    public class GasSaleManager
    {
        GasSaleDal _gasSaleDal;
        public GasSaleManager()
        {
            _gasSaleDal = new GasSaleDal();
        }

        public void AddGasSale(GasSale gasSale)
        {
            _gasSaleDal.Add(gasSale);
        }

        public double TotalRevenue()
        {
            var result = _gasSaleDal.GetAll().Sum(s=>s.Sale);
            return result;
        }
        public IEnumerable<GasSale> TotalRevenueByDate(DateTime start,DateTime end) 
        {
            var result = _gasSaleDal.GetSalesByDate(start, end).GroupBy(s => s.SaleDate.Date).Select(g=>new GasSale { SaleDate=g.Key,Sale=g.Sum(a=>a.Sale)});
            return result;
        }

        public IEnumerable<GasSale> GetAllSales()
        {
            return _gasSaleDal.GetAll();
        }
    }
}
