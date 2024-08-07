using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Customer;

public record ListCustomerQuery : IRequest<IEnumerable<CustomerDto>>;