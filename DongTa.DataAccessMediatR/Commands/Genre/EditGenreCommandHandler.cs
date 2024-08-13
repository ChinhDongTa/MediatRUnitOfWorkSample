using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Genre;

public class EditGenreCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<EditGenreCommand, bool> {

    public async Task<bool> Handle(EditGenreCommand request, CancellationToken cancellationToken)
        => await UnitOfWork.EditGenre(request.Dto);
}