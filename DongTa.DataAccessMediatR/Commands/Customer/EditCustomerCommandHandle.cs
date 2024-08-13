using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Customer;

public class EditCustomerCommandHandle(IChinookUow UnitOfWork) : IRequestHandler<EditCustomerCommand, bool> {

    public async Task<bool> Handle(EditCustomerCommand request, CancellationToken cancellationToken)
    => await UnitOfWork.EditCustomer(request.Dto);
}