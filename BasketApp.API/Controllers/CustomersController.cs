using BasketApp.API.Extensions;
using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Models;
using BasketApp.Domain.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Get all customers.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<ServiceResponseBase<IEnumerable<Customer>>>> GetAllCustomer()
        {
            var serviceResponse = await _customerService.GetAllCustomer();

            if (serviceResponse == null)
                return new ServiceResponseBase<IEnumerable<Customer>>
                {
                    Message = InnerResultTypes.NoCustomerFound.Message()
                };

            return new ServiceResponseBase<IEnumerable<Customer>>
            {
                Success = true,
                Data = serviceResponse
            };
        }

        /// <summary>
        /// Get the customer belonging to the customerId parameter.
        /// </summary>
        /// <param name="customerId"></param>   
        [HttpGet("{customerId}")]
        public async Task<ActionResult<ServiceResponseBase<Customer>>> GetCustomer(int customerId)
        {
            var serviceResponse = await _customerService.GetCustomer(customerId);

            if (serviceResponse == null)
                return new ServiceResponseBase<Customer>
                {
                    Message = InnerResultTypes.NoCustomerFound.Message()
                };

            return new ServiceResponseBase<Customer>
            {
                Success = true,
                Data = serviceResponse
            };
        }
    }
}
