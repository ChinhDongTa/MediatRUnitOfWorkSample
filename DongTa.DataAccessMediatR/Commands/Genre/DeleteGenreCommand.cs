using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Genre;

public record DeleteGenreCommand(int GenreId) : IRequest<bool>;