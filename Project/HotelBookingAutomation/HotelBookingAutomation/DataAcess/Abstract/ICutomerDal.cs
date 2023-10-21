using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Abstract
{
    public interface ICustomerDal
    {
        Task InsertAsync(Customer customer);
        Task DeleteAsync(Customer customer);
        Task UpdateAsync(Customer customer);

        Task<IEnumerable<Customer>> GetAllAsync();
        Task<IEnumerable<Customer>> GetAllBySearchTermAsync(string searchTerm);
        Task<Customer> GetByIdAsync(Guid id);

        Task<Customer> GetByIdentificationAsync(string id);

    }
}
