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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get all products.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<ServiceResponseBase<IEnumerable<Product>>>> GetAllProduct()
        {
            var serviceResponse = await _productService.GetAllProduct();

            if (serviceResponse == null)
                return new ServiceResponseBase<IEnumerable<Product>>
                {
                    Message = InnerResultTypes.NoProductFound.Message()
                };

            return new ServiceResponseBase<IEnumerable<Product>>
            {
                Success = true,
                Data = serviceResponse
            };
        }

        /// <summary>
        /// Get the product for the productVariantId parameter.
        /// </summary>
        /// <param name="productVariantId"></param>   
        [HttpGet("{productVariantId}")]
        public async Task<ActionResult<ServiceResponseBase<Product>>> GetProduct(int productVariantId)
        {
            var serviceResponse = await _productService.GetProductVariantById(productVariantId);

            if (serviceResponse == null)
                return new ServiceResponseBase<Product>
                {
                    Message = InnerResultTypes.NoProductFound.Message()
                };

            return new ServiceResponseBase<Product>
            {
                Success = true,
                Data = serviceResponse
            };
        }
    }
}
