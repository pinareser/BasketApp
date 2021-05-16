using BasketApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface IOptionService
    {
        Task<IEnumerable<Option>> GetOptionsByProductVariantId(int ProductVariantId);
    }
}
