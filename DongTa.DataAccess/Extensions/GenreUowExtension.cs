using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccess.Extensions;

public static class GenreUowExtension {

    public static async Task<GenreDto?> GetGenreDtoById(this IChinookUow uow, int genreId)
    {
        var genre = await uow.GenreRepository.FindByIdAsync(genreId);
        return genre?.ToDto();
    }

    public static async Task<IEnumerable<GenreDto>> GetListGenreDto(this IChinookUow uow)
        => await uow.GenreRepository.GetListBy(x => x.GenreId > 0).Select(x => x.ToDto()).ToListAsync();

    public static async Task<bool> DeleteGenre(this IChinookUow uow, int genreId)
    {
        if (genreId > 0)
        {
            await uow.GenreRepository.DeleteByIdAsync(genreId);
            return await uow.SaveAllAsync();
        }
        return false;
    }

    public static async Task<bool> EditGenre(this IChinookUow uow, GenreDto dto)
    {
        if (dto.GenreId == 0)
        {
            await uow.GenreRepository.InsertAsync(dto.ToEntity());
            return await uow.SaveAllAsync();
        }
        else
        {
            var genre = await uow.GenreRepository.FindByIdAsync(dto.GenreId);
            if (genre is not null)
            {
                await uow.GenreRepository.UpdateAsync(dto.ToEntity(genre));
                return await uow.SaveAllAsync();
            }
        }
        return false;
    }
}