using DongTa.DataAccessMediatR.Commands.Album;
using DongTa.DataAccessMediatR.Queries.Album;
using DongTa.Domain.Dtos;
using DongTa.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("[controller]")]
[ApiController]
public class AlbumMediatRController(IMediator mediator) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new AlbumQuery(id))));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new ListAlbumQuery())));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new DeleteAlbumCommand(id))));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] AlbumDto dto)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new EditAlbumCommand(dto))));
}