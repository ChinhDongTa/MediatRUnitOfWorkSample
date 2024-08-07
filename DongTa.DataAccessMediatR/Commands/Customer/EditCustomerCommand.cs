using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Customer;

public record EditCustomerCommand(CustomerDto Dto) : IRequest<bool>;
