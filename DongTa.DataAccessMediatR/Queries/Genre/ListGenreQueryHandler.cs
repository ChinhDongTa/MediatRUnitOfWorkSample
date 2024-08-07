using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccessMediatR.Queries.Genre;

public class ListGenreQueryHandler(IChinookUow unitOfWork) : IRequestHandler<ListGenreQuery, IEnumerable<GenreDto>?> {

    public async Task<IEnumerable<GenreDto>?> Handle(ListGenreQuery request, CancellationToken cancellationToken)
    {
        return await unitOfWork.GenreRepository.GetListBy(x => x.GenreId > 0).Select(x => new GenreDto(x.GenreId, x.Name)).ToListAsync(cancellationToken);
    }
}