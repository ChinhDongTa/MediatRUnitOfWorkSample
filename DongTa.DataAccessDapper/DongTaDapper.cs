using Dapper;
using Microsoft.Data.SqlClient;

namespace DongTa.DataAccessDapper;

public class DongTaDapper : IDongTaDapper {
    public required string ConnectionString { get; set; }

    public async Task<int> ExecuteAsync(string query)
    {
        if (string.IsNullOrEmpty(ConnectionString))
        {
            return -1;
        }
        else
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            return await connection.ExecuteAsync(query);
        }
    }

    public async Task<IEnumerable<T>?> GetByQueryAsync<T>(string query)
    {
        // string connectionString = Parameter.Connection.ConnectionString(ConnectionType);

        if (string.IsNullOrEmpty(ConnectionString))
        {
            return null;
        }
        else
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            return await connection.QueryAsync<T>(query);
        }
    }

    public async Task<T?> GetOneAsync<T>(string query)
    {
        //string connectionString = Parameter.Connection.ConnectionString(ConnectionType);
        if (string.IsNullOrEmpty(ConnectionString))
        {
            return default;
        }
        else
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            return await connection.QueryFirstOrDefaultAsync<T>(query);
        }
    }
}