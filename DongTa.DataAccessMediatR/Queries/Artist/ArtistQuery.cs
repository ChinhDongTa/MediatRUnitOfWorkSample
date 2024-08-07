using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Artist;
public record ArtistQuery(int Id) : IRequest<ArtistDto>;