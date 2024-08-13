using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Customer;

public class DeleteCustomerCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<DeleteCustomerCommand, bool> {

    public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        => await UnitOfWork.DeleteCustomer(request.CustomerId);
}