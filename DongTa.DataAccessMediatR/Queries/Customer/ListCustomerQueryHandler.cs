using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using DongTa.Domain.Mapping;

namespace DongTa.DataAccessMediatR.Queries.Customer;

public class ListCustomerQueryHandler(IChinookUow unitOfWork) : IRequestHandler<ListCustomerQuery, IEnumerable<CustomerDto>?> {
    public async Task<IEnumerable<CustomerDto>?> Handle(ListCustomerQuery request, CancellationToken cancellationToken)
    {
        return await unitOfWork.CustomerRepository.GetListBy(x => x.CustomerId > 0).Include(x => x.SupportRep).Select(x => x.ToDto()).ToListAsync(cancellationToken: cancellationToken);
    }
}