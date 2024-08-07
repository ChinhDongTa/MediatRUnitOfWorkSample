using DongTa.Domain.Dtos;
using DongTa.Domain.Models;

namespace DongTa.Domain.Mapping;

/// <summary>
/// Chuyển Customer sang CustomerDto và ngược lại
/// </summary>
public static class CustomerMapper {

    /// <summary>
    /// Chuyển Customer sang CustomerDto
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    public static CustomerDto ToDto(this Customer customer) => new()
    {
        CustomerId = customer.CustomerId,
        Email = customer.Email,
        FirstName = customer.FirstName,
        LastName = customer.LastName,
        Address = customer.Address,
        City = customer.City,
        Company = customer.Company,
        Country = customer.Country,
        Fax = customer.Fax,
        Phone = customer.Phone,
        PostalCode = customer.PostalCode,
        State = customer.State,
        SupportRepId = customer.SupportRepId,
        SupportRepName = customer.SupportRep!.FirstName + customer.SupportRep.LastName
    };

    /// <summary>
    /// Chuyển CustomerDto sang Customer
    /// </summary>
    /// <param name="customerDto"></param>
    /// <returns></returns>
    public static Customer ToEntiTy(this CustomerDto customerDto) => new()
    {
        CustomerId = customerDto.CustomerId,
        Email = customerDto.Email,
        FirstName = customerDto.FirstName,
        LastName = customerDto.LastName,
        Address = customerDto.Address,
        City = customerDto.City,
        Company = customerDto.Company,
        Country = customerDto.Country,
        Fax = customerDto.Fax,
        Phone = customerDto.Phone,
        PostalCode = customerDto.PostalCode,
        State = customerDto.State,
        SupportRepId = customerDto.SupportRepId
    };
}