using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Genre;

public record EditGenreCommand(GenreDto Dto) : IRequest<bool>;