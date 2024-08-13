using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Playlist;

public class DeletePlaylistCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<DeletePlaylistCommand, bool> {

    public async Task<bool> Handle(DeletePlaylistCommand request, CancellationToken cancellationToken)
    => await UnitOfWork.DeletePlaylist(request.PlaylistId);
}