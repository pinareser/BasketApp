using BasketApp.API.Extensions;
using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Models;
using BasketApp.Domain.Models.Requests;
using BasketApp.Domain.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApp.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketsController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        /// <summary>
        /// Get the customer's basket for the customerId parameter.
        /// </summary>
        /// <param name="customerId"></param>   
        [HttpGet("{customerId}")]
        public async Task<ActionResult<ServiceResponseBase<BasketViewModel>>> GetBasketByCustomerId(int customerId)
        {
            var serviceResponse = await _basketService.GetBasketViewModel(customerId);

            if (serviceResponse == null || serviceResponse.Basket == null || serviceResponse.Basket.ToList().Count == 0)
                return new ServiceResponseBase<BasketViewModel>
                {
                    Message = InnerResultTypes.IsBasketEmpty.Message()
                };

            return new ServiceResponseBase<BasketViewModel>
            {
                Success = true,
                Data = serviceResponse
            };
        }

        /// <summary>
        /// Adds the products to the basket according to the information received.
        /// </summary>
        /// <param name="postEmailRequest"></param>   
        [HttpPost]
        public async Task<ActionResult<ServiceResponseBase<BasketViewModel>>> PostBasket([FromBody] PostBasketRequest postEmailRequest)
        {
            var serviceResponse = await _basketService.AddProductToBasket(postEmailRequest.ProductVariantId, postEmailRequest.CustomerId, postEmailRequest.Count);

            if (serviceResponse == null || !serviceResponse.Success || serviceResponse.Data == null || serviceResponse.Data.Basket == null || serviceResponse.Data.Basket.ToList().Count == 0)
                return new ServiceResponseBase<BasketViewModel>
                {
                    Message = serviceResponse.Message
                };

            return new ServiceResponseBase<BasketViewModel>
            {
                Success = true,
                Data = serviceResponse.Data
            };
        }
    }
}
