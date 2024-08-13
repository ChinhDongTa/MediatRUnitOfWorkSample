using DongTa.Domain.Dtos;
using DongTa.Domain.Models;

namespace DongTa.Domain.Mapping;

public static class ArtistMapper {

    public static ArtistDto ToDto(this Artist artist)
        => new(artist.ArtistId, artist.Name);

    /// <summary>
    /// Tạo mới hoặc copy giá trị dto tới entity
    /// </summary>
    /// <param name="dto"></param>
    /// <param name="artist"></param>
    /// <returns></returns>
    public static Artist ToEntity(this ArtistDto dto, Artist? artist = null)
    {
        if (artist is not null)
        {
            artist.Name = dto.Name;
            return artist;
        }
        return new()
        {
            ArtistId = dto.ArtistId,
            Name = dto.Name
        };
    }
}