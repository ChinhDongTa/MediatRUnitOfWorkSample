using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccessMediatR.Queries.Playlist;

public class ListPlaylistQueryHandler(IChinookUow unitOfWork) : IRequestHandler<ListPlaylistQuery, IEnumerable<PlaylistDto>?> {

    public async Task<IEnumerable<PlaylistDto>?> Handle(ListPlaylistQuery request, CancellationToken cancellationToken)
    {
        return await unitOfWork.PlaylistRepository.GetListBy(x => x.PlaylistId > 0).Select(x => new PlaylistDto(x.PlaylistId, x.Name)).ToListAsync(cancellationToken: cancellationToken);
    }
}