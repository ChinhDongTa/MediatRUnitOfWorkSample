using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Album;

public record ListAlbumQuery : IRequest<IEnumerable<AlbumDto>>;
