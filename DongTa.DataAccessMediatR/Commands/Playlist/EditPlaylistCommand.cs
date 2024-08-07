using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Playlist;

public record EditPlaylistCommand(PlaylistDto Dto) : IRequest<bool>;