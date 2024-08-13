using DongTa.Domain.Dtos;
using DongTa.Domain.Models;

namespace DongTa.Domain.Mapping;

public static class GenreMapper {

    public static GenreDto ToDto(this Genre genre)
        => new(genre.GenreId, genre.Name);

    /// <summary>
    /// Tạo mới hoặc copy giá trị dto tới entity
    /// </summary>
    /// <param name="dto"></param>
    /// <param name="genre"></param>
    /// <returns></returns>
    public static Genre ToEntity(this GenreDto dto, Genre? genre = null)
    {
        if (genre is not null)
        {
            genre.Name = dto.Name;
            return genre;
        }
        return new()
        {
            GenreId = dto.GenreId,
            Name = dto.Name
        };
    }
}