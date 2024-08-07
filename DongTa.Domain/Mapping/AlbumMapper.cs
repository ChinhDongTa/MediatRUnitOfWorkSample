using DongTa.Domain.Dtos;
using DongTa.Domain.Models;

namespace DongTa.Domain.Mapping;

public static class AlbumMapper {

    public static AlbumDto ToDto(this Album album) => new(album.AlbumId, album.Title, album.ArtistId, album.Artist.Name ?? "");

    public static Album ToEntity(this AlbumDto dto) => new() { AlbumId = dto.AlbumId, Title = dto.Title, ArtistId = dto.ArtistId };
}