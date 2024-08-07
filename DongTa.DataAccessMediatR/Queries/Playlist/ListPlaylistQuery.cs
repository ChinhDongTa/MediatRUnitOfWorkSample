using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Playlist;

public record ListPlaylistQuery : IRequest<IEnumerable<PlaylistDto>>;