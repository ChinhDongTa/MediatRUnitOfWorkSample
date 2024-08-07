using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Artist;

public record ListArtistQuery : IRequest<IEnumerable<ArtistDto>>;
