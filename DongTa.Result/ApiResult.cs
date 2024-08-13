namespace DongTa.Result;
public record ApiResult<T> {
    public ApiResult(bool isSuccess, Message msg, IEnumerable<T> Dtos)
    {
        if ((isSuccess && Dtos is null) || !isSuccess && Dtos.Any())
        {
            throw new ArgumentException("Invalid error", nameof(Dtos));
        }
        if (Dtos.Any())
        {
            IsSuccess = isSuccess;
            Message = msg;
            this.Dtos = Dtos;
        }
        else//nếu không có phần tử nào
        {
            IsSuccess = false;
            Message = new Message(LevelMessage.Warning, "Không có phần tử nào trong danh sách");
            this.Dtos = null;
        }
    }

    public ApiResult(bool isSuccess, Message msg, T Dto)
    {
        if ((isSuccess && Dto is null) || !isSuccess && Dto is not null)
        {
            throw new ArgumentException("Invalid error", nameof(Dto));
        }
        IsSuccess = isSuccess;
        Message = msg;
        this.Dto = Dto;
    }

    public ApiResult(bool isSuccess, Message msg)
    {
        IsSuccess = isSuccess;
        Message = msg;
    }
    public ApiResult(bool isSuccess, string msg)
    {
        IsSuccess = isSuccess;
        Message = IsSuccess ? new Message(LevelMessage.Success, msg) : new Message(LevelMessage.Error, msg);
    }
    public bool IsSuccess { get; }
    public Message Message { get; }
    public DateTime ResponseTime => DateTime.Now;
    public T? Dto { get; }
    public IEnumerable<T>? Dtos { get; }
    public static ApiResult<T> Failure(Message error) => new(false, error);
    public static ApiResult<T> Failure(string error) => new(false, error);
    public static ApiResult<T> Success(string successMessage) => new(true, successMessage);
    public static ApiResult<T> Success(IEnumerable<T> dtos, string? message = null)
        => message is null ? new(true, Message.Success, dtos) : new(true, new Message(LevelMessage.Success, message), dtos);

    public static ApiResult<T> Success(T dto, string? message = null)
        => message is null ? new(true, Message.Success, dto) : new(true, new Message(LevelMessage.Success, message), dto);

    /// <summary>
    /// Dùng đẻ kiểm tra đúng sai của 1 hành động
    /// </summary>
    /// <param name="isSuccess"></param>
    /// <returns></returns>
    public static ApiResult<bool> BoolResult(bool isSuccess)
        => isSuccess ? ApiResult<bool>.Success("Success") : ApiResult<bool>.Failure("Failed");
}