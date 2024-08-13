using DongTa.Domain.Dtos;
using DongTa.Domain.Models;

namespace DongTa.Domain.Mapping;

public static class AlbumMapper {

    public static AlbumDto ToDto(this Album album) => new(album.AlbumId, album.Title, album.ArtistId, album.Artist.Name ?? "");

    /// <summary>
    /// Tạo mới hoặc copy giá trị dto tới entity
    /// </summary>
    /// <param name="dto"></param>
    /// <param name="album"></param>
    /// <returns></returns>
    public static Album ToEntity(this AlbumDto dto, Album? album = null)
    {
        //Copy value
        if (album is not null)
        {
            album.Title = dto.Title;
            album.ArtistId = dto.ArtistId;
            return album;
        }
        return new()
        {
            AlbumId = dto.AlbumId,
            Title = dto.Title,
            ArtistId = dto.ArtistId
        };
    }
}