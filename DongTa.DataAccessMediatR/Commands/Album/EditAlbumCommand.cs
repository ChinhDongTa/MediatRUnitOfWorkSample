using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Album;
public record EditAlbumCommand(AlbumDto Dto) : IRequest<bool>;