using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccessMediatR.Queries.MediaType;

public class ListMediaTypeQueryHandler(IChinookUow unitOfWork) : IRequestHandler<ListMediaTypeQuery, IEnumerable<MediaTypeDto>?> {

    public async Task<IEnumerable<MediaTypeDto>?> Handle(ListMediaTypeQuery request, CancellationToken cancellationToken)
    => await unitOfWork.GetListMediaTypeDto();
}