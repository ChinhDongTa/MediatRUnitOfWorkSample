using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.MediaType;

public class EditMediaTypeCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<EditMediaTypeCommand, bool> {

    public async Task<bool> Handle(EditMediaTypeCommand request, CancellationToken cancellationToken)
    {
        if (request.Dto.MediaTypeId == 0)
        {
            await UnitOfWork.MediaTypeRepository.InsertAsync(new Domain.Models.MediaType { Name = request.Dto.Name });
            return await UnitOfWork.SaveAllAsync();
        }
        else
        {
            var mt = await UnitOfWork.MediaTypeRepository.FindByIdAsync(request.Dto.MediaTypeId);
            if (mt != null)
            {
                mt.Name = request.Dto.Name;
                await UnitOfWork.MediaTypeRepository.UpdateAsync(mt);
                return await UnitOfWork.SaveAllAsync();
            }
        }
        return false;
    }
}