using DongTa.DataAccessMediatR.Commands.Album;
using DongTa.DataAccessMediatR.Queries.Album;
using DongTa.Domain.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlbumMediatRController(IMediator mediator) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetAlbumById(int id)
        => Ok((AlbumDto?)await mediator.Send(new AlbumQuery(id)));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum()
        => Ok((IEnumerable<AlbumDto>?)await mediator.Send(new ListAlbumQuery()));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(await mediator.Send(new DeleteAlbumCommand(id)));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] AlbumDto dto)
        => Ok(await mediator.Send(new EditAlbumCommand(dto)));
}