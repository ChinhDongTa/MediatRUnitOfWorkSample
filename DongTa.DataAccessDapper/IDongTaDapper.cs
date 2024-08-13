namespace DongTa.DataAccessDapper;

public interface IDongTaDapper {

    Task<IEnumerable<T>?> GetByQueryAsync<T>(string query);

    Task<T?> GetOneAsync<T>(string query);

    /// <summary>
    /// Add, update, delete
    /// </summary>
    /// <param name="query"></param>
    /// <returns>number row efected</returns>
    Task<int> ExecuteAsync(string query);

    string ConnectionString { get; set; }
}