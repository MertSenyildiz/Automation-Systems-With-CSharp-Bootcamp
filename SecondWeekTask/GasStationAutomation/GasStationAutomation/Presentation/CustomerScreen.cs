using GasStationAutomation.Business;
using GasStationAutomation.Models;
using MarketStationAutomation.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GasStationAutomation.Presentation
{
    public class CustomerScreen : IScreen
    {
        ProductManager _productManager;
        MarketSaleManager _marketSaleManager;
        public CustomerScreen()
        {
            _marketSaleManager = new MarketSaleManager();
            _productManager = new ProductManager();
        }
        public void Show()
        {
            List<Product> cart = new();
            while(true)
            {
                ShowOptions();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ShowItems();
                        break;
                    case 2:
                        AddItemToCart(cart);
                        break;
                    case 3:
                        ShowItemsInCart(cart);
                        break;
                    case 4:
                        CompleteShopping(cart);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Not a valid option!");
                        break;
                }
            }
        }

        private void CompleteShopping(List<Product> cart)
        {
            if (cart.Any())
            {
                var sale=new MarketSale() { SaleDate=DateTime.Now ,Sale=cart.Sum(i=>i.Price)};
                _marketSaleManager.AddMarketSale(sale);
                Console.WriteLine($"Shopping Completed.\n Cost: {sale.Sale.ToString("00.##")}\n Date: {sale.SaleDate}");
            }
            else
            {
                Console.WriteLine("Shopping Cart is Empty");
            }
        }

        private void ShowItemsInCart(List<Product> cart)
        {
            foreach(var item in cart)
            {
                Console.WriteLine($"{item.Name}\t\t{item.Price.ToString("00.##")}");
            }
            Console.WriteLine($"Total Amount: {cart.Sum(i=>i.Price).ToString("00.##")}");
        }

        private void AddItemToCart(List<Product> cart)
        {
            Console.Write("Item id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var item=_productManager.GetById(id);
            if(item is not null)
            {
                cart.Add(item);
                Console.WriteLine($"{item.Name} is added to the cart.");
            }
            else
            {
                Console.WriteLine("No item found...");
            }
        }

        private void ShowItems()
        {
            var result=_productManager.GetAllProducts();
            foreach (var item in result)
            {
                Console.WriteLine($"ID: {item.ID}\t\t Name: {item.Name}\t\t Price: {item.Price.ToString("00.##")}");
            }
        }

        void ShowOptions()
        {
            Console.WriteLine("------------CUSTOMER PANEL------------");
            Console.WriteLine("1-Show Items");
            Console.WriteLine("2-Add Item to Cart");
            Console.WriteLine("3-Show Items in the Cart");
            Console.WriteLine("4-Complete Shopping");
            Console.WriteLine("5-Exit");
            Console.Write("Choose an option: ");
        }
    }
}
