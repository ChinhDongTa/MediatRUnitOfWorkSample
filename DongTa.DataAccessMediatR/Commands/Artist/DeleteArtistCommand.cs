using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Artist;
public record DeleteArtistCommand(int ArtistId) : IRequest<bool>;