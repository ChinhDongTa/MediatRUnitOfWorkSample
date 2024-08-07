using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Customer;

public class EditCustomerCommandHandle(IChinookUow UnitOfWork) : IRequestHandler<EditCustomerCommand, bool> {

    public async Task<bool> Handle(EditCustomerCommand request, CancellationToken cancellationToken)
    {
        //add new
        if (request.Dto.CustomerId == 0)
        {
            await UnitOfWork.CustomerRepository.InsertAsync(request.Dto.ToEntiTy());
            return await UnitOfWork.SaveAllAsync();
        }
        else
        {
            await UnitOfWork.CustomerRepository.UpdateAsync(request.Dto.ToEntiTy());
            return await UnitOfWork.SaveAllAsync();
        }
    }
}