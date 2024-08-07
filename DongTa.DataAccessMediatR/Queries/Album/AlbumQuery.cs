using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.Album;
public record AlbumQuery(int Id) : IRequest<AlbumDto>;