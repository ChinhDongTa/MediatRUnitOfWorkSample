using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.MediaType;

public class DeleteMediaTypeCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<DeleteMediaTypeCommand, bool> {

    public async Task<bool> Handle(DeleteMediaTypeCommand request, CancellationToken cancellationToken)
    {
        if (request.MediaTypeId > 0)
        {
            await UnitOfWork.MediaTypeRepository.DeleteByIdAsync(request.MediaTypeId);
            return await UnitOfWork.SaveAllAsync();
        }
        return false;
    }
}