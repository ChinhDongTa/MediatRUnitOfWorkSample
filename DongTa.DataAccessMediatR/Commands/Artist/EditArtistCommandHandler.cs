using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Artist;

public class EditArtistCommandHandler(IChinookUow unitOfWork) : IRequestHandler<EditArtistCommand, bool> {

    public async Task<bool> Handle(EditArtistCommand request, CancellationToken cancellationToken)
        => await unitOfWork.EditArtist(request.ArtistDto);
}