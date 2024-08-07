using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Album {
    public record DeleteAlbumCommand(int AlbumId) : IRequest<bool>;
}