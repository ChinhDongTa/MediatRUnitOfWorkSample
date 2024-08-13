namespace DongTa.Domain.Dtos;

public record ApiResultDto<T> {
    public bool IsSuccess { get; set; }
    public Message? Message { get; set; }
    public T? Dto { get; set; }
    public IEnumerable<T>? Dtos { get; set; }
}