using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccessMediatR.Queries.Genre;

public class ListGenreQueryHandler(IChinookUow unitOfWork) : IRequestHandler<ListGenreQuery, IEnumerable<GenreDto>> {

    public async Task<IEnumerable<GenreDto>> Handle(ListGenreQuery request, CancellationToken cancellationToken)
    => await unitOfWork.GetListGenreDto();
}