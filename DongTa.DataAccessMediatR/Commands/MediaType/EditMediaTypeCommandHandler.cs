using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.MediaType;

public class EditMediaTypeCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<EditMediaTypeCommand, bool> {

    public async Task<bool> Handle(EditMediaTypeCommand request, CancellationToken cancellationToken)
        => await UnitOfWork.EditMediaType(request.Dto);
}