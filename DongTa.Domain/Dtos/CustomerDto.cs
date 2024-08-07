namespace DongTa.Domain.Dtos;

public record CustomerDto {
    public required int CustomerId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Company { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public required string Email { get; set; }
    public int? SupportRepId { get; set; }
    public string? SupportRepName { get; set; }
}