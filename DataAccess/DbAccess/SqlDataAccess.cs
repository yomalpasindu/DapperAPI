using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;

        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<T>> LoadData<T, U>(string stroedProcedure,
                                                        U parameters,
                                                        string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));
            return await connection.QueryAsync<T>(stroedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task SaveData<T>(string stroedProcedure,
                                      T parameters,
                                      string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));
            await connection.ExecuteAsync(stroedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
