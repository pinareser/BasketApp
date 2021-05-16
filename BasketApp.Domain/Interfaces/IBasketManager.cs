using BasketApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface IBasketManager
    {
        Task<InnerResult<bool>> CanAddToBasket(IEnumerable<Basket> basketProduct, int productVariantId, int customerId, int count);
    }
}
