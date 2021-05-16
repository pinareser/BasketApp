using BasketApp.API.Extensions;
using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApp.API.Managers
{
    public class BasketManager : IBasketManager
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public BasketManager(ICustomerService customerService, IProductService productService)
        {
            _customerService = customerService;
            _productService = productService;
        }

        public async Task<InnerResult<bool>> CanAddToBasket(IEnumerable<Basket> basketProducts, int productVariantId, int customerId, int count)
        {
            if (count <= 0)
                return new InnerResult<bool>
                {
                    Message = InnerResultTypes.InvalidCountValue.Message(),
                    InnerResultType = InnerResultTypes.InvalidCountValue
                };

            bool isCustomerExist = await _customerService.IsCustomerExist(customerId);
            if (!isCustomerExist)
                return new InnerResult<bool>
                {
                    Message = InnerResultTypes.NoCustomerFound.Message(),
                    InnerResultType = InnerResultTypes.NoCustomerFound
                };

            var product = await _productService.GetProductVariantById(productVariantId);
            if (product == null)
                return new InnerResult<bool>
                {
                    Message = InnerResultTypes.NoProductFound.Message(),
                    InnerResultType = InnerResultTypes.NoProductFound
                };

            if (basketProducts != null)
            {
                var basketProduct = basketProducts.FirstOrDefault(x => x?.Product?.ProductVariantId == product.ProductVariantId);
                if (basketProduct != null)
                    count += basketProduct.Count;
            }

            var success = product.Stock >= count;

            return new InnerResult<bool>
            {
                Success = success,
                Message = !success ? InnerResultTypes.NotEnoughStock.Message() : string.Empty,
                Data = success,
                InnerResultType = !success ? InnerResultTypes.NotEnoughStock : InnerResultTypes.Success
            };
        }
    }
}
