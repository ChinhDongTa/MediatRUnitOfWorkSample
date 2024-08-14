using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DongTa.Result;

namespace DongTa.ApiServer.Controllers;

[Route("[controller]")]
[ApiController]
public class GenreUowController(IChinookUow uow) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id)
        => Ok(ApiResultExtension.GetApiResult(await uow.GetGenreDtoById(id)));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum()
        => Ok(ApiResultExtension.GetApiResult(await uow.GetListGenreDto()));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(ApiResultExtension.GetApiResult(await uow.DeleteGenre(id)));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] GenreDto dto)
        => Ok(ApiResultExtension.GetApiResult(await uow.EditGenre(dto)));
}