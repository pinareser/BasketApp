using BasketApp.Data;
using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Models;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApp.API.Services
{
    public class ProductService : IProductService
    {
        private readonly BasketAppDbContext _basketAppDbContext;
        private readonly IQueryRepository _queryRepository;
        private readonly IOptionService _optionService;

        public ProductService(BasketAppDbContext basketAppDbContext, IQueryRepository queryRepository, IOptionService optionService)
        {
            _basketAppDbContext = basketAppDbContext;
            _queryRepository = queryRepository;
            _optionService = optionService;
        }

        public async Task<IEnumerable<Product>> GetAllProduct() =>
            await GetProducts();

        public async Task<Product> GetProductVariantById(int productVariantId)
        {
            var product = await GetProducts(productVariantIdList:
               new List<int>
               {
                   productVariantId
               });

            return product.FirstOrDefault();
        }

        public async Task<bool> IsProductExist(int productVariantId) =>
            await _basketAppDbContext.TbProductVariants.AnyAsync(x => x.Id == productVariantId);

        public async Task<IEnumerable<Product>> GetProducts(List<int> productVariantIdList = null)
        {
            var productQuery = @"
                SELECT 
                    P.Id AS ProductId, 
                    PV.Id AS ProductVariantId,
                    P.Name AS ProductName,
                    PV.Name AS ProductVariantName,                       
                    PV.Description AS Description, 
                    PV.Price AS Price, 
                    PV.Stock AS Stock,
                    P.CreateDate AS CreateDate
                FROM
                TB_Product AS P
                INNER JOIN TB_ProductVariant AS PV ON P.Id = PV.ProductId
                INNER JOIN TB_ProductOption AS PO ON PV.Id = PO.ProductVariantId";

            object parameters = null;

            if (productVariantIdList != null)
            {
                productQuery += " WHERE PV.Id IN (@productVariantIdList)";
                parameters = new DynamicParameters(
                   new
                   {
                       productVariantIdList = string.Join(',', productVariantIdList)
                   });
            }

            var productList = await _queryRepository.ExecuteQuery<Product>(productQuery, parameters);
            foreach (var product in productList)
                product.Options = await _optionService.GetOptionsByProductVariantId(product.ProductVariantId);

            return productList;
        }
    }
}
