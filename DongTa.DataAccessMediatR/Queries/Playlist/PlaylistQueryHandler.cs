using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Playlist;

public class PlaylistQueryHandler(IChinookUow unitOfWork) : IRequestHandler<PlaylistQuery, PlaylistDto?> {

    public async Task<PlaylistDto?> Handle(PlaylistQuery request, CancellationToken cancellationToken)
    {
        var pl = await unitOfWork.PlaylistRepository.FindByIdAsync(request.Id);
        if (pl == null) return null;
        return new PlaylistDto(pl.PlaylistId, pl.Name);
    }
}