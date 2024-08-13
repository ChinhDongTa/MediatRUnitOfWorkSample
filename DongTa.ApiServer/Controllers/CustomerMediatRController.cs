﻿using DongTa.DataAccessMediatR.Commands.Playlist;
using DongTa.DataAccessMediatR.Queries.Customer;
using DongTa.Domain.Dtos;
using DongTa.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DongTa.ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerMediatRController(IMediator mediator) : ControllerBase
{
    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new CustomerQuery(id))));
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new ListCustomerQuery())));
    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
       => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new DeletePlaylistCommand(id))));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] PlaylistDto dto)
        => Ok(ApiResultExtension.GetApiResult(await mediator.Send(new EditPlaylistCommand(dto))));
}