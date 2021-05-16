using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface IQueryRepository
    {
        public Task<IEnumerable<T>> ExecuteQuery<T>(string query, object parameters = null);
    }
}
