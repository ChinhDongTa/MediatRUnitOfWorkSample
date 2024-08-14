using DongTa.DataAccessMediatR.Commands.MediaType;
using DongTa.DataAccessMediatR.Queries.MediaType;
using DongTa.Domain.Dtos;
using DongTa.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("[controller]")]
[ApiController]
public class MediaTypeMediatRController(IMediator mediator) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new MediaTypeQuery(id))));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum()
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new ListMediaTypeQuery())));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new DeleteMediaTypeCommand(id))));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] MediaTypeDto dto)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new EditMediaTypeCommand(dto))));
}