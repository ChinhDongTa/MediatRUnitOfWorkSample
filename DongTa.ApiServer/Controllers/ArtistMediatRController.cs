using DongTa.DataAccessMediatR.Commands.Album;
using DongTa.DataAccessMediatR.Commands.Artist;
using DongTa.DataAccessMediatR.Queries.Artist;
using DongTa.Domain.Dtos;
using DongTa.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("[controller]")]
[ApiController]
public class ArtistMediatRController(IMediator mediator) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new ArtistQuery(id))));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum()
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new ListArtistQuery())));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new DeleteAlbumCommand(id))));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] ArtistDto dto)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new EditArtistCommand(dto))));
}