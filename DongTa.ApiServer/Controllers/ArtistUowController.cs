using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArtistUowController(IChinookUow uow) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id) => Ok(await uow.GetArtistDtoById(id));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum() => Ok(await uow.GetListArtistDto());

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id) => Ok(await uow.DeleteArtist(id));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] ArtistDto dto) => Ok(await uow.EditArtist(dto));
}