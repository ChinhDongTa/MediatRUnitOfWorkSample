using DongTa.DataAccess.Extensions;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Album {

    public class EditAlbumCommandHandler(IChinookUow unitOfWork) : IRequestHandler<EditAlbumCommand, bool> {

        public async Task<bool> Handle(EditAlbumCommand request, CancellationToken cancellationToken)
        {
            return await unitOfWork.EditAlbum(request.Dto);
        }
    }
}