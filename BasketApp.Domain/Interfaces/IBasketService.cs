using BasketApp.Domain.Models;
using BasketApp.Domain.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface IBasketService
    {
        Task<BasketViewModel> GetBasketViewModel(int customerId);
        Task<InnerResult<BasketViewModel>> AddProductToBasket(int productVariantId, int customerId, int count);
        Task<IEnumerable<Basket>> GetBasketProducts(int customerId);
    }
}
