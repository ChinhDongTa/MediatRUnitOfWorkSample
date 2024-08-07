using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Genre;

public class EditGenreCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<EditGenreCommand, bool> {

    public async Task<bool> Handle(EditGenreCommand request, CancellationToken cancellationToken)
    {
        if (request.Dto.GenreId == 0)
        {
            await UnitOfWork.GenreRepository.InsertAsync(new Domain.Models.Genre { GenreId = request.Dto.GenreId, Name = request.Dto.Name });
            return await UnitOfWork.SaveAllAsync();
        }
        else
        {
            var genre = await UnitOfWork.GenreRepository.FindByIdAsync(request.Dto.GenreId);
            if (genre is not null)
            {
                genre.Name = request.Dto.Name;
                await UnitOfWork.GenreRepository.UpdateAsync(genre);
                return await UnitOfWork.SaveAllAsync();
            }
        }
        return false;
    }
}