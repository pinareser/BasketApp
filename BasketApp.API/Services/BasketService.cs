using BasketApp.API.Extensions;
using BasketApp.API.Mappers;
using BasketApp.Data;
using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Models;
using BasketApp.Domain.Models.Responses;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApp.API.Services
{
    public class BasketService : IBasketService
    {
        private readonly BasketAppDbContext _basketAppDbContext;
        private readonly IQueryRepository _queryRepository;
        private readonly IProductService _productService;
        private readonly IBasketManager _basketManager;

        public BasketService(BasketAppDbContext basketAppDbContext, IQueryRepository queryRepository, IProductService optionService, IBasketManager basketManager)
        {
            _basketAppDbContext = basketAppDbContext;
            _queryRepository = queryRepository;
            _productService = optionService;
            _basketManager = basketManager;
        }

        public async Task<BasketViewModel> GetBasketViewModel(int customerId)
        {
            var basketViewModel = new BasketViewModel();
            var basketList = await GetBasketProducts(customerId);

            foreach (var basket in basketList)
            {
                if (basket != null && basket.Product != null)
                {
                    basketViewModel.TotalCount += basket.Count;
                    basketViewModel.TotalPrice += basket.Product.Price * basket.Count;
                }
            }

            basketViewModel.Basket = basketList;

            return basketViewModel;
        }

        public async Task<InnerResult<BasketViewModel>> AddProductToBasket(int productVariantId, int customerId, int count)
        {
            var basketProducts = await GetBasketProducts(customerId);
            var canAddToBasket = await _basketManager.CanAddToBasket(basketProducts, productVariantId, customerId, count);

            if (canAddToBasket == null)
                return new InnerResult<BasketViewModel>
                {
                    Message = InnerResultTypes.CannotBeAddedToBasket.Message(),
                    InnerResultType = InnerResultTypes.CannotBeAddedToBasket
                };


            if (canAddToBasket != null && !canAddToBasket.Data)
                return new InnerResult<BasketViewModel>
                {
                    Message = canAddToBasket.Message,
                    InnerResultType = canAddToBasket.InnerResultType
                };

            var tbBasket = new TbBasket
            {
                ProductVariantId = productVariantId,
                CustomerId = customerId,
                CreateDate = DateTime.Now
            };

            var isProductExistInBasket = await IsProductExistInBasket(productVariantId, customerId);

            if (isProductExistInBasket)
            {
                if (basketProducts != null)
                {
                    var basketItem = basketProducts.FirstOrDefault(x => x?.Product?.ProductVariantId == productVariantId);
                    count += basketItem.Count;

                    tbBasket.Id = basketItem.BasketId;
                    tbBasket.Count = count;

                    _basketAppDbContext.Entry(tbBasket).State = EntityState.Modified;
                }
            }
            else
            {
                tbBasket.Count = count;
                await _basketAppDbContext.AddAsync(tbBasket);
            }

            var result = await _basketAppDbContext.SaveChangesAsync();
            var customerBasket = await GetBasketViewModel(customerId);
            var success = result > 0;

            return new InnerResult<BasketViewModel>
            {
                Success = success,
                Message = success ? InnerResultTypes.SuccessfullyAddedToBasket.Message() : InnerResultTypes.CannotBeAddedToBasket.Message(),
                Data = customerBasket,
                InnerResultType = success ? InnerResultTypes.SuccessfullyAddedToBasket : InnerResultTypes.CannotBeAddedToBasket
            };
        }

        public async Task<IEnumerable<Basket>> GetBasketProducts(int customerId)
        {
            var basketList = new List<Basket>();
            var basketQuery = @"
                SELECT 
                   B.Id AS Id,
                   B.Count AS Count,
	               B.CustomerId AS CustomerId,
                   B.ProductVariantId AS ProductVariantId
                FROM 
                TB_Basket AS B
                INNER JOIN TB_Customer AS C ON B.CustomerId = C.Id
                INNER JOIN TB_ProductVariant AS PV ON B.ProductVariantId = PV.Id
                WHERE B.CustomerId = @customerId";

            var parameters = new DynamicParameters(
                   new
                   {
                       customerId
                   });

            var result = await _queryRepository.ExecuteQuery<TbBasket>(basketQuery, parameters);

            foreach (var basket in result)
            {
                var product = await _productService.GetProductVariantById(basket.ProductVariantId);

                basketList.Add(new Basket
                {
                    BasketId = basket.Id,
                    CustomerId = basket.CustomerId,
                    Count = basket.Count,
                    Product = product.Map(),
                    ProductTotalPrice = basket.Count * product.Price,
                });
            }

            return basketList;
        }

        public async Task<bool> IsProductExistInBasket(int productVariantId, int customerId) =>
            await _basketAppDbContext.TbBaskets.AnyAsync(x => x.ProductVariantId == productVariantId && x.CustomerId == customerId);
    }
}
