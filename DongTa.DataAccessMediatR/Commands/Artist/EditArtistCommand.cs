using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.Artist;

public record EditArtistCommand(ArtistDto ArtistDto) : IRequest<bool>;