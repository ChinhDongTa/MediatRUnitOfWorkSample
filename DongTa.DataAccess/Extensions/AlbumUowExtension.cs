using Azure.Core;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace DongTa.DataAccess.Extensions;

public static class AlbumUowExtension {

    public static async Task<AlbumDto?> GetAlbumDtoById(this IChinookUow uow, int albumId)
    {
        var album = await uow.AlbumRepository.GetListBy(x => x.AlbumId == albumId)
            .Include(x => x.Artist)
            .FirstOrDefaultAsync();
        if (album == null)
            return null;
        return new AlbumDto(album.AlbumId, album.Title, album.ArtistId, album.Artist.Name ?? "");
    }

    public static async Task<IEnumerable<AlbumDto>> GetListAlbumDto(this IChinookUow uow)
    {
        return await uow.AlbumRepository.GetListBy(x => x.AlbumId > 0).Include(x => x.Artist).Select(x => x.ToDto()).ToListAsync();
    }

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
        if (albumDto.ArtistId == 0)//add
        {
            await uow.AlbumRepository.InsertAsync(albumDto.ToEntity());
            return await uow.SaveAllAsync();
        }
        else//update
        {
            await uow.AlbumRepository.UpdateAsync(albumDto.ToEntity());
            return await uow.SaveAllAsync();
        }
    }
}