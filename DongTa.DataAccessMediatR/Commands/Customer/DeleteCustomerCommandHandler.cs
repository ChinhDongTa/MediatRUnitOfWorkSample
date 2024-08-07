using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Customer;

public class DeleteCustomerCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<DeleteCustomerCommand, bool> {

    public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        if (request.CustomerId > 0)
        {
            await UnitOfWork.CustomerRepository.DeleteByIdAsync(request.CustomerId);
            return await UnitOfWork.SaveAllAsync();
        }
        return false;
    }
}