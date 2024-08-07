using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Genre;

public class GenreQueryHandler(IChinookUow unitOfWork) : IRequestHandler<GenreQuery, GenreDto?> {
    public async Task<GenreDto?> Handle(GenreQuery request, CancellationToken cancellationToken)
    {
        var genre = await unitOfWork.GenreRepository.FindByIdAsync(request.Id);
        if (genre == null)
        {
            return null;
        }
        return new GenreDto(genre.GenreId, genre.Name);
    }
}
