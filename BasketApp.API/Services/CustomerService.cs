using BasketApp.API.Mappers;
using BasketApp.Data;
using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly BasketAppDbContext _basketAppDbContext;

        public CustomerService(BasketAppDbContext basketAppDbContext)
        {
            _basketAppDbContext = basketAppDbContext;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer()
        {
            var customer = await _basketAppDbContext.TbCustomers.ToListAsync();
            return customer.Map();
        }

        public async Task<Customer> GetCustomer(int customerId)
        {
            var customer = await _basketAppDbContext.TbCustomers.FirstOrDefaultAsync(x => x.Id == customerId);
            return customer.Map();
        }

        public async Task<bool> IsCustomerExist(int customerId) =>
             await _basketAppDbContext.TbCustomers.AnyAsync(x => x.Id == customerId);
    }
}
