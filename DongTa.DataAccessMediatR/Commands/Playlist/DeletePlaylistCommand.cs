using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Playlist;
public record DeletePlaylistCommand(int PlaylistId) : IRequest<bool>;