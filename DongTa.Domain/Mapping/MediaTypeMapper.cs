using DongTa.Domain.Dtos;
using DongTa.Domain.Models;

namespace DongTa.Domain.Mapping;

public static class MediaTypeMapper {

    public static MediaTypeDto ToDto(this MediaType mediaType)
        => new(mediaType.MediaTypeId, mediaType.Name);

    /// <summary>
    /// Tạo mới hoặc copy giá trị dto tới entity
    /// </summary>
    /// <param name="dto"></param>
    /// <param name="mediaType"></param>
    /// <returns></returns>
    public static MediaType ToEntity(this MediaTypeDto dto, MediaType? mediaType = null)
    {
        if (mediaType is not null)
        {
            mediaType.Name = dto.Name;
            return mediaType;
        }
        return new()
        {
            MediaTypeId = dto.MediaTypeId,
            Name = dto.Name
        };
    }
}