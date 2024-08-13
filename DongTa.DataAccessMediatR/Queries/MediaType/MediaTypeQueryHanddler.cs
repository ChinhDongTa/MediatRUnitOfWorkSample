using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.MediaType;

public class MediaTypeQueryHanddler(IChinookUow unitOfWork) : IRequestHandler<MediaTypeQuery, MediaTypeDto?> {

    public async Task<MediaTypeDto?> Handle(MediaTypeQuery request, CancellationToken cancellationToken)
    => await unitOfWork.GetMediaTypeDtoById(request.Id);
}