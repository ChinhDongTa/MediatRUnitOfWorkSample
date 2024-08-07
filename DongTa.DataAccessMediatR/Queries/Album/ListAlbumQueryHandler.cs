using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Album;

public record ListAlbumQueryHandler(IChinookUow Uow) : IRequestHandler<ListAlbumQuery, IEnumerable<AlbumDto>> {
    public async Task<IEnumerable<AlbumDto>> Handle(ListAlbumQuery request, CancellationToken cancellationToken)
    {
        return await Uow.GetListAlbumDto();
    }
}