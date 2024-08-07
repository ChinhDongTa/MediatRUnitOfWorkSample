using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Artist;

public class DeleteArtistCommandHandler(IChinookUow unitOfWork) : IRequestHandler<DeleteArtistCommand, bool> {

    public async Task<bool> Handle(DeleteArtistCommand request, CancellationToken cancellationToken)
        => await unitOfWork.DeleteArtist(request.ArtistId);
}