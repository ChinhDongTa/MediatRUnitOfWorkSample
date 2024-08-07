using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Playlist;

public class DeletePlaylistCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<DeletePlaylistCommand, bool> {

    public async Task<bool> Handle(DeletePlaylistCommand request, CancellationToken cancellationToken)
    {
        if (request.PlaylistId > 0)
        {
            await UnitOfWork.PlaylistRepository.DeleteByIdAsync(request.PlaylistId);
            return await UnitOfWork.SaveAllAsync();
        }
        return false;
    }
}