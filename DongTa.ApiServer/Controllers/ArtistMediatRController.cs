using DongTa.DataAccessMediatR.Commands.Album;
using DongTa.DataAccessMediatR.Commands.Artist;
using DongTa.DataAccessMediatR.Queries.Artist;
using DongTa.Domain.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArtistMediatRController(IMediator mediator) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id) => Ok(await mediator.Send(new ArtistQuery(id)));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum() => Ok(await mediator.Send(new ListArtistQuery()));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id) => Ok(await mediator.Send(new DeleteAlbumCommand(id)));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] ArtistDto dto) => Ok(await mediator.Send(new EditArtistCommand(dto)));
}