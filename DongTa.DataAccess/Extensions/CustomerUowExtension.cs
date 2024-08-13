using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccess.Extensions;

public static class CustomerUowExtension {

    public static async Task<CustomerDto?> GetCustomerDtoById(this IChinookUow uow, int customerId)
        => await uow.CustomerRepository.GetListBy(x => x.CustomerId == customerId)
            .Include(x => x.SupportRep)
            .Select(x => x.ToDto())
            .FirstOrDefaultAsync();

    public static async Task<IEnumerable<CustomerDto>> GetListCustomerDtos(this IChinookUow uow)
        => await uow.CustomerRepository.GetListBy(x => x.CustomerId > 0)
        .Include(x => x.SupportRep)
        .Select(x => x.ToDto()).ToListAsync();

    public static async Task<bool> DeleteCustomer(this IChinookUow uow, int customerId)
    {
        if (customerId > 0)
        {
            await uow.CustomerRepository.DeleteByIdAsync(customerId);
            return await uow.SaveAllAsync();
        }
        return false;
    }

    public static async Task<bool> EditCustomer(this IChinookUow uow, CustomerDto dto)
    {
        //add new
        if (dto.CustomerId == 0)
        {
            await uow.CustomerRepository.InsertAsync(dto.ToEntiTy());
            return await uow.SaveAllAsync();
        }
        else
        {
            var customer = await uow.CustomerRepository.FindByIdAsync(dto.CustomerId);
            if (customer is not null)
            {
                await uow.CustomerRepository.UpdateAsync(dto.ToEntiTy(customer));
                return await uow.SaveAllAsync();
            }
        }
        return false;
    }
}