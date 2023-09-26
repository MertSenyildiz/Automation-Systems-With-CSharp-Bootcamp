using GasStationAutomation.Business;
using GasStationAutomation.DataAccess;
using GasStationAutomation.Models;
using GasStationAutomation.Presentation;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace GasStationAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IScreen _screen;
            while (true) 
            {
                ShowOptions();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        _screen=new CashierScreen();
                        _screen.Show();
                        break;
                    case 2:
                        _screen = new CustomerScreen();
                        _screen.Show();
                        break;
                    case 3:
                        _screen=new OwnerScreen();
                        _screen.Show();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Not a valid option!");
                        break;
                }
            }

        }
        static void ShowOptions()
        {
                Console.WriteLine("------------PANEL------------");
                Console.WriteLine("1-Cashier");
                Console.WriteLine("2-Customer");
                Console.WriteLine("3-Owner");
                Console.WriteLine("4-Exit");
                Console.Write("Choose an option: ");
        }
    }
}