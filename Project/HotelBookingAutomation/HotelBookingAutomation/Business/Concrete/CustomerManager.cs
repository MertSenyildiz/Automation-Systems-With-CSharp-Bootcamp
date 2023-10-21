using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal cutomerDal)
        {
            _customerDal = cutomerDal;
        }

        public async Task DeleteCustomerAsync(Customer customer)
        {
            try
            {
                await _customerDal.DeleteAsync(customer);
            }catch (Exception ex) { }
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            try
            {
                return await _customerDal.GetAllAsync();
            }catch (Exception ex) { }
            return null;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersBySearchTermAsync(string searchTerm)
        {
            try
            {
                return await _customerDal.GetAllBySearchTermAsync(searchTerm);
            }catch (Exception ex) { }
            return null;
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            try
            {

                return await _customerDal.GetByIdAsync(id);

            }catch (Exception ex) { }
            return null;
        }

        public async Task<Customer> GetCustomerByIdentificationAsync(string id)
        {
            try
            {
                return await _customerDal.GetByIdentificationAsync(id);
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task InsertCustomerAsync(Customer customer)
        {
            try
            {
                await _customerDal.InsertAsync(customer);
            }
            catch (Exception ex) { }
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            try
            {
                await _customerDal.UpdateAsync(customer);
            }
            catch (Exception ex) { }
        }
    }
}
