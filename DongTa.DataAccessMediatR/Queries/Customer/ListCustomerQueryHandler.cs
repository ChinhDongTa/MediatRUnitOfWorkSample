using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using DongTa.Domain.Mapping;
using DongTa.DataAccess.Extensions;

namespace DongTa.DataAccessMediatR.Queries.Customer;

public class ListCustomerQueryHandler(IChinookUow unitOfWork) : IRequestHandler<ListCustomerQuery, IEnumerable<CustomerDto>?> {

    public async Task<IEnumerable<CustomerDto>?> Handle(ListCustomerQuery request, CancellationToken cancellationToken)
        => await unitOfWork.GetListCustomerDtos();
}