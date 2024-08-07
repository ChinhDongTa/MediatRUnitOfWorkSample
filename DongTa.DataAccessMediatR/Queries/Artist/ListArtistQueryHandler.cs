using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Artist;

public class ListArtistQueryHandler(IChinookUow unitOfWork) : IRequestHandler<ListArtistQuery, IEnumerable<ArtistDto>> {

    public async Task<IEnumerable<ArtistDto>> Handle(ListArtistQuery request, CancellationToken cancellationToken)
    {
        return await unitOfWork.GetListArtistDto();
    }
}