using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.Presentation
{
    public class OwnerScreen : IScreen
    {
        List<IScreen> _screens;
        public OwnerScreen()
        {
            _screens = new List<IScreen>();
            _screens.Add(new OwnerMarketScreen());
            _screens.Add(new OwnerGasPumpScreen());
        }
        public void Show()
        {
            while(true)
            {
                ShowOptions();
                int option=Convert.ToInt32(Console.ReadLine());
                if (option == 1 || option == 2)
                {
                    _screens[option-1].Show();
                }
                else if (option == 3)
                    return;
                else
                    Console.WriteLine("Not a valid option!");
            }
        }

        void ShowOptions()
        {
            Console.WriteLine("------------OWNER PANEL------------");
            Console.WriteLine("1-Market");
            Console.WriteLine("2-Gas Pumps");
            Console.WriteLine("3-Exit");
            Console.Write("Choose an option: ");
        }

    }
}
