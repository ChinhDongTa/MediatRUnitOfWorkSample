using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Customer;

public class CustomerQueryHandler(IChinookUow unitOfWork) : IRequestHandler<CustomerQuery, CustomerDto?> {

    public async Task<CustomerDto?> Handle(CustomerQuery request, CancellationToken cancellationToken)
        => await unitOfWork.GetCustomerDtoById(request.Id);
}