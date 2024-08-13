using DongTa.DataAccess.Extensions;
using DongTa.Domain.Dtos;
using DongTa.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DongTa.Result;

namespace DongTa.ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MediaTypeUowController(IChinookUow uow) : ControllerBase {

    [HttpGet("GetOne/{id}")]
    public async Task<IActionResult> GetOne(int id) => Ok(ApiResultExtension.GetApiResult(await uow.GetMediaTypeDtoById(id)));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllAlbum() => Ok(ApiResultExtension.GetApiResult(await uow.GetListMediaTypeDto()));

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id) => Ok(ApiResultExtension.GetApiResult(await uow.DeleteMediaType(id)));

    [HttpPost("Edit")]
    public async Task<IActionResult> Edit([FromBody] MediaTypeDto dto) => Ok(ApiResultExtension.GetApiResult(await uow.EditMediaType(dto)));
}