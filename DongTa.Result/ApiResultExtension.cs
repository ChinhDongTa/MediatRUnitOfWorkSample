namespace DongTa.Result;

public static class ApiResultExtension {

    public static ApiResult<T> GetApiResult<T>(T? t, string? message = null)
        => t is null ? ApiResult<T>.Failure(Message.NotFound)
                     : message is null ? ApiResult<T>.Success(t) : ApiResult<T>.Success(t, message);

    public static ApiResult<T> GetApiResult<T>(IEnumerable<T>? t, string? message = null)
        => t is null ? ApiResult<T>.Failure(Message.NotFound)
                     : message is null ? ApiResult<T>.Success(t) : ApiResult<T>.Success(t, message);

    public static ApiResult<T> GetApiResult<T>(List<T> t, string? message = null) => GetApiResult<T>(t.AsEnumerable(), message);
}