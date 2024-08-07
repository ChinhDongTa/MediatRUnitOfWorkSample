using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Playlist;

public class EditPlaylistCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<EditPlaylistCommand, bool> {

    public async Task<bool> Handle(EditPlaylistCommand request, CancellationToken cancellationToken)
    {
        if (request.Dto.PlaylistId == 0)
        {
            await UnitOfWork.PlaylistRepository.InsertAsync(new Domain.Models.Playlist { Name = request.Dto.Name });
            return await UnitOfWork.SaveAllAsync();
        }
        else
        {
            var pl = await UnitOfWork.PlaylistRepository.FindByIdAsync(request.Dto.PlaylistId);
            if (pl != null)
            {
                pl.Name = request.Dto.Name;
                await UnitOfWork.PlaylistRepository.UpdateAsync(pl);
                return await UnitOfWork.SaveAllAsync();
            }
        }
        return false;
    }
}