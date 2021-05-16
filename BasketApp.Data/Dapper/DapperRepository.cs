using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasketApp.Data.Dapper
{
    public class DapperRepository : IQueryRepository
    {
        private readonly AppSettings _appSettings;
        private readonly SqlConnection _connection;

        public DapperRepository(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _connection = new SqlConnection(_appSettings.BasketAppDatabase);
        }

        public async Task<IEnumerable<T>> ExecuteQuery<T>(string query, object parameters = null) =>
            await _connection.QueryAsync<T>(query, parameters);
    }
}
