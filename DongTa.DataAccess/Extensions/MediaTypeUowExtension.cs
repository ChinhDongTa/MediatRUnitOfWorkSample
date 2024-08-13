using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DongTa.DataAccess.Extensions;

public static class MediaTypeUowExtension {

    public static async Task<MediaTypeDto?> GetMediaTypeDtoById(this IChinookUow uow, int mediaTypeId)
    {
        var media = await uow.MediaTypeRepository.FindByIdAsync(mediaTypeId);
        return media?.ToDto();
    }

    public static async Task<IEnumerable<MediaTypeDto>> GetListMediaTypeDto(this IChinookUow uow)
        => await uow.MediaTypeRepository.GetListBy(x => x.MediaTypeId > 0)
        .Select(x => x.ToDto())
        .ToListAsync();

    public static async Task<bool> DeleteMediaType(this IChinookUow uow, int mediaTypeId)
    {
        if (mediaTypeId > 0)
        {
            await uow.MediaTypeRepository.DeleteByIdAsync(mediaTypeId);
            return await uow.SaveAllAsync();
        }
        return false;
    }

    public static async Task<bool> EditMediaType(this IChinookUow uow, MediaTypeDto dto)
    {
        if (dto.MediaTypeId == 0)
        {
            await uow.MediaTypeRepository.InsertAsync(dto.ToEntity());
            return await uow.SaveAllAsync();
        }
        else
        {
            var mt = await uow.MediaTypeRepository.FindByIdAsync(dto.MediaTypeId);
            if (mt != null)
            {
                await uow.MediaTypeRepository.UpdateAsync(dto.ToEntity(mt));
                return await uow.SaveAllAsync();
            }
        }
        return false;
    }
}