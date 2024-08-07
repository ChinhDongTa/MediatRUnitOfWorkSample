using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using DongTa.Domain.Mapping;

namespace DongTa.DataAccessMediatR.Queries.Customer;

public class CustomerQueryHandler(IChinookUow unitOfWork) : IRequestHandler<CustomerQuery, CustomerDto?> {

    public async Task<CustomerDto?> Handle(CustomerQuery request, CancellationToken cancellationToken)
    {
        return await unitOfWork.CustomerRepository.GetListBy(x => x.CustomerId == request.Id)
            .Include(x => x.SupportRep)
            .Select(x => x.ToDto())
            .FirstOrDefaultAsync(cancellationToken: cancellationToken);
    }
}