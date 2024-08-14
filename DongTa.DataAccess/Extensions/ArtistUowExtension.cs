using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccess.Extensions;

public static class ArtistUowExtension {

    public static async Task<ArtistDto?> GetArtistDtoById(this IChinookUow uow, int artistId)
        => (await uow.ArtistRepository.GetOneAsync(x => x.ArtistId == artistId))?.ToDto();

    public static async Task<IEnumerable<ArtistDto>> GetListArtistDto(this IChinookUow uow)
        => await uow.ArtistRepository.GetListBy(x => x.ArtistId > 0)
            .Select(x => x.ToDto())
            .ToListAsync();

    public static async Task<bool> DeleteArtist(this IChinookUow uow, int artistId)
    {
        if (artistId > 0)
        {
            _ = await uow.ArtistRepository.DeleteByIdAsync(artistId);
            return await uow.SaveAllAsync();
        }
        return false;
    }

    public static async Task<bool> EditArtist(this IChinookUow uow, ArtistDto dto)
    {
        if (dto.ArtistId == 0)
        {
            await uow.ArtistRepository.InsertAsync(dto.ToEntity());
            return await uow.SaveAllAsync();
        }
        else
        {
            var artist = await uow.ArtistRepository.FindByIdAsync(dto.ArtistId);
            if (artist is not null)
            {
                await uow.ArtistRepository.UpdateAsync(dto.ToEntity(artist));
                return await uow.SaveAllAsync();
            }
        }
        return false;
    }
}