using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Genre;

public class DeleteGenreCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<DeleteGenreCommand, bool> {

    public async Task<bool> Handle(DeleteGenreCommand request, CancellationToken cancellationToken)
    {
        if (request.GenreId > 0)
        {
            await UnitOfWork.GenreRepository.DeleteByIdAsync(request.GenreId);
            return await UnitOfWork.SaveAllAsync();
        }
        return false;
    }
}