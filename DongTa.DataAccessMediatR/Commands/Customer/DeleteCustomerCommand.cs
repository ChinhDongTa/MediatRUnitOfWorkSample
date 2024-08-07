using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Customer;
public record DeleteCustomerCommand(int CustomerId) : IRequest<bool>;