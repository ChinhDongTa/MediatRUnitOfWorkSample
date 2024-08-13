using DongTa.DataAccessMediatR.Commands.Genre;
using DongTa.DataAccessMediatR.Queries.Genre;
using DongTa.Domain.Dtos;
using DongTa.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenreMediatRController(IMediator mediator) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new GenreQuery(id))));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum()
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new ListGenreQuery())));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new DeleteGenreCommand(id))));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] GenreDto dto)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new EditGenreCommand(dto))));
}