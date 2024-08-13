using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Genre;

public class GenreQueryHandler(IChinookUow unitOfWork) : IRequestHandler<GenreQuery, GenreDto?> {

    public async Task<GenreDto?> Handle(GenreQuery request, CancellationToken cancellationToken)
        => await unitOfWork.GetGenreDtoById(request.Id);
}