using BasketApp.Data;
using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Models;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.API.Services
{
    public class OptionService : IOptionService
    {
        private readonly IQueryRepository _queryRepository;

        public OptionService(IQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public async Task<IEnumerable<Option>> GetOptionsByProductVariantId(int productVariantId)
        {
            var optionQuery = @"
                   SELECT 
                        O.Id AS OptionId, 
                        OG.Id AS OptionGroupId,
                        PO.ProductVariantId AS ProductVariantId,
                        O.Name AS OptionName, 
                        OG.Name AS OptionGroupName
                   FROM 
                   TB_Option AS O
                   INNER JOIN TB_OptionGroup AS OG ON O.OptionGroupId = OG.Id
                   INNER JOIN TB_ProductOption AS PO ON O.Id = PO.OptionId
                   WHERE PO.ProductVariantId = @productVariantId";

            var parameters = new DynamicParameters(
                new
                {
                    productVariantId
                });

            return await _queryRepository.ExecuteQuery<Option>(optionQuery, parameters);
        }
    }
}
