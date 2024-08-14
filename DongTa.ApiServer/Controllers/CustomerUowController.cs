using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DongTa.Result;

namespace DongTa.ApiServer.Controllers;

[Route("[controller]")]
[ApiController]
public class CustomerUowController(IChinookUow uow) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id)
        => Ok(ApiResultExtension.GetApiResult(await uow.GetCustomerDtoById(id)));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum()
        => Ok(ApiResultExtension.GetApiResult(await uow.GetListCustomerDtos()));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(ApiResultExtension.GetApiResult(await uow.DeletePlaylist(id)));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] PlaylistDto dto)
        => Ok(ApiResultExtension.GetApiResult(await uow.EditPlaylist(dto)));
}