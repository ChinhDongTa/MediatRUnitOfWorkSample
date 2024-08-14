using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Artist;

public class ArtistQueryHandler(IChinookUow unitOfWork) : IRequestHandler<ArtistQuery, ArtistDto?> {

    public async Task<ArtistDto?> Handle(ArtistQuery request, CancellationToken cancellationToken)
        => await unitOfWork.GetArtistDtoById(request.Id);
}