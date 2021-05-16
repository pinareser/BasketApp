using BasketApp.Domain.Entities;
using BasketApp.Domain.Models;
using System.Collections.Generic;

namespace BasketApp.API.Mappers
{
    public static class CustomerMapper
    {
        public static Customer Map(this TbCustomer customer) =>
            customer != null ? new Customer
            {
                CustomerId = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                Email = customer.Email,
                Address = customer.Address,
                PhoneNumber = customer.PhoneNumber
            }
            : null;

        public static List<Customer> Map(this List<TbCustomer> customer)
        {
            var _customer = new List<Customer>();

            if (customer != null && customer.Count != 0)
                foreach (var subVendor in customer)
                    _customer.Add(subVendor.Map());

            return _customer;
        }
    }
}
