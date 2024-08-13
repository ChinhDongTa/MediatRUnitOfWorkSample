using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Album;

public class DeleteAlbumCommandHandler(IChinookUow unitOfWork) : IRequestHandler<DeleteAlbumCommand, bool> {

    public async Task<bool> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        => await unitOfWork.DeleteAlbum(request.AlbumId);
}