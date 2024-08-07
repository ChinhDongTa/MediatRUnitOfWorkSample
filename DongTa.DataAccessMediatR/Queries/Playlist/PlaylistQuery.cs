using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Playlist;
public record PlaylistQuery(int Id) : IRequest<PlaylistDto>;