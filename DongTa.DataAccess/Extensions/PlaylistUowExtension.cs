using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccess.Extensions;

public static class PlaylistUowExtension {

    public static async Task<PlaylistDto?> GetPlaylistDtoById(this IChinookUow uow, int playlistId)
        => (await uow.PlaylistRepository.FindByIdAsync(playlistId))?.ToDto();

    public static async Task<IEnumerable<PlaylistDto>> GetListPlaylistDto(this IChinookUow uow)
        => await uow.PlaylistRepository.GetListBy(x => x.PlaylistId > 0)
        .Select(x => x.ToDto())
        .ToListAsync();

    public static async Task<bool> DeletePlaylist(this IChinookUow uow, int playlistId)
    {
        if (playlistId > 0)
        {
            await uow.PlaylistRepository.DeleteByIdAsync(playlistId);
            return await uow.SaveAllAsync();
        }
        return false;
    }

    public static async Task<bool> EditPlaylist(this IChinookUow uow, PlaylistDto dto)
    {
        if (dto.PlaylistId == 0)
        {
            await uow.PlaylistRepository.InsertAsync(dto.ToEntity());
            return await uow.SaveAllAsync();
        }
        else
        {
            var pl = await uow.PlaylistRepository.FindByIdAsync(dto.PlaylistId);
            if (pl != null)
            {
                await uow.PlaylistRepository.UpdateAsync(dto.ToEntity(pl));
                return await uow.SaveAllAsync();
            }
        }
        return false;
    }
}