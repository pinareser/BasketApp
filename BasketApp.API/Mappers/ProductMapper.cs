using BasketApp.Domain.Models;

namespace BasketApp.API.Mappers
{
    public static class ProductMapper
    {
        public static BasketProduct Map(this Product product) =>
           product != null ? new BasketProduct
           {
               ProductId = product.ProductId,
               ProductVariantId = product.ProductVariantId,
               ProductVariantName = product.ProductVariantName,
               Price = product.Price,
               Options = product.Options
           }
           : null;
    }
}
