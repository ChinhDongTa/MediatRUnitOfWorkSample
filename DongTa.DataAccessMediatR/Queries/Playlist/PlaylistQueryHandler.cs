using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Playlist;

public class PlaylistQueryHandler(IChinookUow unitOfWork) : IRequestHandler<PlaylistQuery, PlaylistDto?> {

    public async Task<PlaylistDto?> Handle(PlaylistQuery request, CancellationToken cancellationToken)
    => await unitOfWork.GetPlaylistDtoById(request.Id);
}