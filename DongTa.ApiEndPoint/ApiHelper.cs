using System.Net.Http.Json;
using System.Net;
using System.Text.Json;

namespace DongTa.ApiEndPoint;

public static class ApiHelper {

    public static readonly HttpClient Client = new()
    {
        BaseAddress = new Uri("https://localhost:7496/") //Uri(" http://localhost:5247")
    };

    /// <summary>
    /// Post T tới Api server
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="api"></param>
    /// <param name="dto"></param>
    /// <returns></returns>
    public static async Task<bool> PostAsJsonAsync<T>(string api, T dto)
    {
        using var response = await Client.PostAsJsonAsync(api, dto);
        return response.StatusCode == HttpStatusCode.OK;
    }

    /// <summary>
    /// Lấy 1 T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="api"></param>
    /// <returns></returns>
    public static async Task<T?> GetApiResultDtoAsync<T>(string api)
    {
        string? jsonString = await GetJsonString(api);
        return string.IsNullOrEmpty(jsonString) ? default : JsonSerializer.Deserialize<T>(jsonString, options: GetJsonSerializerOptions());
    }

    private static async Task<string?> GetJsonString(string api)
    {
        var response = await Client.GetAsync(api);

        return response.StatusCode == HttpStatusCode.OK && response != null ? response.Content.ReadAsStringAsync().Result : null;
    }

    internal static JsonSerializerOptions GetJsonSerializerOptions(bool value = true)
        => new() { PropertyNameCaseInsensitive = value };
}