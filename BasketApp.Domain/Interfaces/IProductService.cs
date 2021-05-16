using BasketApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> GetProductVariantById(int productVariantId);
        Task<bool> IsProductExist(int productVariantId);
    }
}
