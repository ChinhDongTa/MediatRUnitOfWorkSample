using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Genre;

public class DeleteGenreCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<DeleteGenreCommand, bool> {

    public async Task<bool> Handle(DeleteGenreCommand request, CancellationToken cancellationToken)
        => await UnitOfWork.DeleteGenre(request.GenreId);
}