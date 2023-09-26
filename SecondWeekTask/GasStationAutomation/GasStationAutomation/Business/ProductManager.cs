using GasStationAutomation.DataAccess;
using GasStationAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.Business
{
    public class ProductManager
    {
        ProductDal _productDal;
        public ProductManager() { 
            _productDal = new ProductDal();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetAll().Where(x=>x.ID==id).FirstOrDefault();
        }
    }
}
