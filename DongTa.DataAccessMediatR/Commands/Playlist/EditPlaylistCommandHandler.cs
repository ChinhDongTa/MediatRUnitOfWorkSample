using DongTa.Domain.Interfaces;
using DongTa.DataAccess.Extensions;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Playlist;

public class EditPlaylistCommandHandler(IChinookUow UnitOfWork) : IRequestHandler<EditPlaylistCommand, bool> {

    public async Task<bool> Handle(EditPlaylistCommand request, CancellationToken cancellationToken)
    => await UnitOfWork.EditPlaylist(request.Dto);
}