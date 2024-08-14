using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using DongTa.Result;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("[controller]")]
[ApiController]
public class AlbumUowController(IChinookUow uow) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetAlbumById(int id)
        => Ok(ApiResultExtension.GetApiResult(await uow.GetAlbumDtoById(id)));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum()
        => Ok(ApiResultExtension.GetApiResult(await uow.GetListAlbumDto()));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(ApiResultExtension.GetApiResult(await uow.DeleteAlbum(id)));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] AlbumDto dto)
        => Ok(ApiResultExtension.GetApiResult(await uow.EditAlbum(dto)));
}