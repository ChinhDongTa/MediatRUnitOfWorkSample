using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlbumUowController(IChinookUow uow) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetAlbumById(int id)
        => Ok(await uow.GetAlbumDtoById(id));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum()
        => Ok((IEnumerable<AlbumDto>?)await uow.GetListAlbumDto());

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await uow.DeleteAlbum(id));
    }

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] AlbumDto dto)
        => Ok(await uow.EditAlbum(dto));
}