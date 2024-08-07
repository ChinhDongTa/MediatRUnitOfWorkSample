using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Genre;

public record ListGenreQuery : IRequest<IEnumerable<GenreDto>>;
