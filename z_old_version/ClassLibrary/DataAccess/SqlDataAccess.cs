using System;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace ClassLibrary.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;

        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = _configuration.GetConnectionString(connectionStringName);

            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(
                    storedProcedure,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return rows.ToList();
            }
        }

        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = _configuration.GetConnectionString(connectionStringName);
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(
                    storedProcedure,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}