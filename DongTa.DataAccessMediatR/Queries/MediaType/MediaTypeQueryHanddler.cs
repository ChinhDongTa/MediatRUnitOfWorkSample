using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.MediaType;

public class MediaTypeQueryHanddler(IChinookUow unitOfWork) : IRequestHandler<MediaTypeQuery, MediaTypeDto?> {

    public async Task<MediaTypeDto?> Handle(MediaTypeQuery request, CancellationToken cancellationToken)
    {
        var media = await unitOfWork.MediaTypeRepository.FindByIdAsync(request.Id);
        if (media == null) return null;
        return new MediaTypeDto(media.MediaTypeId, media.Name);
    }
}