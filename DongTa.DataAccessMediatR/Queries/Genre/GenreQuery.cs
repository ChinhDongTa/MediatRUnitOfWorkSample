using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Genre;
public record GenreQuery(int Id) : IRequest<GenreDto>;