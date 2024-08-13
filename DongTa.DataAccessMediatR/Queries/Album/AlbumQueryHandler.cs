using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;
using DongTa.DataAccess.Extensions;

namespace DongTa.DataAccessMediatR.Queries.Album;

public record AlbumQueryHandler(IChinookUow Uow) : IRequestHandler<AlbumQuery, AlbumDto?> {
    public async Task<AlbumDto?> Handle(AlbumQuery request, CancellationToken cancellationToken)
        => await Uow.GetAlbumDtoById(request.Id);
}