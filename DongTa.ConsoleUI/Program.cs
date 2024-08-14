// See https://aka.ms/new-console-template for more information
using DongTa.ApiEndPoint;
using DongTa.ApiEndPoint.Urls;
using DongTa.Domain.Dtos;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Xin chào!");
Console.ReadLine();//chờ api server chạy xong.
Console.WriteLine("Get Album by Id using Unit of work");
var apiDto1 = await ApiHelper.GetApiResultDtoAsync<ApiResultDto<AlbumDto>>(CRUDBase.GetOne(ControllerName.AlbumUow, 1));
Console.WriteLine(apiDto1);

Console.WriteLine("/nGet Artist by Id using MediatR");
var apiDto2 = await ApiHelper.GetApiResultDtoAsync<ApiResultDto<ArtistDto>>(CRUDBase.GetOne(ControllerName.ArtistMediatR, 1));
Console.WriteLine(apiDto2);