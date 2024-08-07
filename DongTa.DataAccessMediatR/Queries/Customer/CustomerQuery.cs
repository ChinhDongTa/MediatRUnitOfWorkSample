using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Customer;
public record CustomerQuery(int Id) : IRequest<CustomerDto>;