using BasketApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomer();
        Task<Customer> GetCustomer(int customerId);
        Task<bool> IsCustomerExist(int customerId);
    }
}
