using DongTa.Domain.Dtos;
using DongTa.Domain.Models;

namespace DongTa.Domain.Mapping;

public static class PlaylistMapper {

    public static PlaylistDto ToDto(this Playlist playlist)
        => new(playlist.PlaylistId, playlist.Name);

    /// <summary>
    /// Tạo mới hoặc copy giá trị dto tới entity
    /// </summary>
    /// <param name="dto"></param>
    /// <param name="playlist"></param>
    /// <returns></returns>
    public static Playlist ToEntity(this PlaylistDto dto, Playlist? playlist = null)
    {
        if (playlist is not null)
        {
            playlist.Name = dto.Name;
            return playlist;
        }
        return new()
        {
            PlaylistId = dto.PlaylistId,
            Name = dto.Name
        };
    }
}