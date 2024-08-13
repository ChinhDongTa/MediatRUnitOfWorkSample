using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.MediaType;

public class DeleteMediaTypeCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<DeleteMediaTypeCommand, bool> {

    public async Task<bool> Handle(DeleteMediaTypeCommand request, CancellationToken cancellationToken)
    => await UnitOfWork.DeleteMediaType(request.MediaTypeId);
}