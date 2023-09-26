using GasStationAutomation.Business;
using MarketStationAutomation.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.Presentation
{
    internal class OwnerGasPumpScreen : IScreen
    {
        GasSaleManager _gasSaleManager;
        public OwnerGasPumpScreen()
        {
            _gasSaleManager = new();
        }
        public void Show()
        {
            while (true)
            {
                ShowOptions();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        TodaysRevenue();
                        break;
                    case 2:
                        RevenueByDates();
                        break;
                    case 3:
                        TotalRevenue();
                        break;
                    case 4:
                        ListAllSales();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Not a valid option!");
                        break;

                }
            }
        }

        void ShowOptions()
        {
            Console.WriteLine("------------OWNER GAS PUMP PANEL------------");
            Console.WriteLine("1-Today's Revenue");
            Console.WriteLine("2-Revenue By Dates");
            Console.WriteLine("3-Total Revenue");
            Console.WriteLine("4-List All Sales");
            Console.WriteLine("5-Exit");
            Console.Write("Choose an option: ");
        }

        void TodaysRevenue()
        {
            var result = _gasSaleManager.TotalRevenueByDate(DateTime.Now.Date,DateTime.Now.AddDays(1).Date);
            if(result.Any())
            {
                Console.WriteLine($"Today's Revenue:{result.First().Sale.ToString("00.##")}");
            }
            else
            {
                Console.WriteLine("No sales in that date");
            }
        }
        void RevenueByDates()
        {
            DateTime start,end;
            Console.Write("Date:");
            DateTime.TryParse(Console.ReadLine(), out start);
            Console.Write("Date:");
            DateTime.TryParse(Console.ReadLine(), out end);
            var result = _gasSaleManager.TotalRevenueByDate(start,end);
            if(result is not null)
            {
                foreach( var item in result)
                {
                    Console.WriteLine($"Date: {item.SaleDate.Date}\t\t Revenue: {item.Sale.ToString("00.##")}");
                }
            }
            else
            {
                Console.WriteLine("Check out the dates!");
            }
        }

        void TotalRevenue()
        {
            var result = _gasSaleManager.TotalRevenue();
            Console.WriteLine($"Total Revenue so far is {result.ToString("00.##")}");
        }

        void ListAllSales()
        {
            var result = _gasSaleManager.GetAllSales();
            foreach (var sale in result)
            {
                Console.WriteLine($"Date: {sale.SaleDate}\t\t Sale: {sale.Sale.ToString("00.##")}");
            }
        }
    }
}
