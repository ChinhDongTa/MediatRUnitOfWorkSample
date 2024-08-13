using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccess.Extensions;

public static class AlbumUowExtension {

    public static async Task<AlbumDto?> GetAlbumDtoById(this IChinookUow uow, int albumId)
    {
        var album = await uow.AlbumRepository.GetListBy(x => x.AlbumId == albumId)
            .Include(x => x.Artist)
            .FirstOrDefaultAsync();
        return album?.ToDto();
    }

    public static async Task<IEnumerable<AlbumDto>> GetListAlbumDto(this IChinookUow uow)
        => await uow.AlbumRepository.GetListBy(x => x.AlbumId > 0)
        .Include(x => x.Artist)
        .Select(x => x.ToDto())
        .ToListAsync();

    public static async Task<bool> DeleteAlbum(this IChinookUow uow, int albumId)
    {
        if (albumId > 0)
        {
            _ = await uow.AlbumRepository.DeleteByIdAsync(albumId);
            return await uow.SaveAllAsync();
        }
        return false;
    }

    public static async Task<bool> EditAlbum(this IChinookUow uow, AlbumDto albumDto)
    {
        if (albumDto.AlbumId == 0)//add
        {
            await uow.AlbumRepository.InsertAsync(albumDto.ToEntity());
            return await uow.SaveAllAsync();
        }
        else//update
        {
            var album = await uow.AlbumRepository.FindByIdAsync(albumDto.AlbumId);
            if (album is not null)
            {
                await uow.AlbumRepository.UpdateAsync(albumDto.ToEntity(album));
                return await uow.SaveAllAsync();
            }
        }
        return false;
    }
}