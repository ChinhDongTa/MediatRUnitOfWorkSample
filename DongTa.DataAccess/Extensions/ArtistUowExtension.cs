using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccess.Extensions;

public static class ArtistUowExtension {

    public static async Task<ArtistDto?> GetArtistDtoById(this IChinookUow uow, int artistId)
    {
        var artist = await uow.ArtistRepository.GetOneAsync(x => x.ArtistId == artistId);
        if (artist == null) return null;
        return new ArtistDto(artist.ArtistId, artist.Name);
    }

    public static async Task<IEnumerable<ArtistDto>> GetListArtistDto(this IChinookUow uow)
    {
        return await uow.ArtistRepository.GetListBy(x => x.ArtistId > 0)
            .Select(x => new ArtistDto(x.ArtistId, x.Name))
            .ToListAsync();
    }

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
            await uow.ArtistRepository.InsertAsync(new Domain.Models.Artist { Name = dto.Name });
            return await uow.SaveAllAsync();
        }
        else
        {
            var artist = await uow.ArtistRepository.FindByIdAsync(dto.ArtistId);
            if (artist is not null)
            {
                artist.Name = dto.Name;
                await uow.ArtistRepository.UpdateAsync(artist);
                return await uow.SaveAllAsync();
            }
        }
        return false;
    }
}