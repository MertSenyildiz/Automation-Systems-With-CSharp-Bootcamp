using GasStationAutomation.Business;
using GasStationAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.Presentation
{
    public class CashierScreen : IScreen
    {
        GasSaleManager _gasSaleManager;
        public CashierScreen()
        {
            _gasSaleManager = new GasSaleManager();
        }
        public void Show()
        {
            while(true)
            {
                ShowOptions();
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                    AddGasSale();
                else if (option == 2)
                    return;
                else
                    Console.WriteLine("Not a valid option!");
            }
        }

        void ShowOptions()
        {
            Console.WriteLine("------------CASHIER PANEL------------");
            Console.WriteLine("1-Add Sale");
            Console.WriteLine("2-Exit");
            Console.Write("Choose an option: ");
        }
        void AddGasSale()
        {
            Console.Write("Amount: ");
            double gas = Convert.ToDouble(Console.ReadLine());
            GasSale sale = new() {Sale=gas,SaleDate=DateTime.Now};
            _gasSaleManager.AddGasSale(sale);
        }
    }
}
