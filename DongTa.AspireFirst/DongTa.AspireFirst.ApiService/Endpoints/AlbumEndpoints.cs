using DongTa.DataAccessMediatR.Queries.Album;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Mapping;
using DongTa.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DongTa.AspireFirst.ApiService.Endpoints;

public static class AlbumEndpoints {

    public static void RegisterAlBumEndpoints(this IEndpointRouteBuilder routes)
    {
        var api = routes.MapGroup("/AlbumUow");
        //Test ok
        api.MapGet("All", static async ([FromServices] IChinookUow uOW) =>
        {
            var albums = await uOW.AlbumRepository.GetListBy(x => x.AlbumId < 5)
                             //.Include(x => x.Tracks)
                             .Include(x => x.Artist).Select(x => x.ToDto())
                             .ToListAsync();
            return Results.Ok(ApiResultExtension.GetApiResult(albums));
        });
        //Test ok
        api.MapGet("One/{id:int}", static async (int id, [FromServices] IChinookUow uOW) =>
        {
            var album = await uOW.AlbumRepository.FindByIdAsync(id);
            return Results.Ok(ApiResultExtension.GetApiResult(album));
        });
        //Test ok
        api.MapGet("GetBy/{id:int}", static async (int id, [FromServices] ISender mediatr) =>
        {
            var album = await mediatr.Send(new AlbumQuery(id));
            return Results.Ok(ApiResultExtension.GetApiResult(album));
        });
    }
}

public static class ArtistEndpoints {

    public static void RegisterArtistEndpoints(this IEndpointRouteBuilder routes)
    {
        var api = routes.MapGroup("/ArtistUow");
        //Test ok
        api.MapGet("All", static async ([FromServices] IChinookUow uOW) =>
        {
            var artists = await uOW.ArtistRepository.GetListBy(x => x.ArtistId > 0).Select(x => x.ToDto())
                             //.Include(x => x.Tracks)

                             .ToListAsync();
            return Results.Ok(ApiResultExtension.GetApiResult(artists));
        });
        //Test ok
        api.MapGet("One/{id:int}", static async (int id, [FromServices] IChinookUow uOW) =>
        {
            var artist = await uOW.ArtistRepository.FindByIdAsync(id);
            return Results.Ok(ApiResultExtension.GetApiResult(artist));
        });
        //Test ok
        api.MapGet("GetBy/{id:int}", static async (int id, [FromServices] ISender mediatr) =>
        {
            var album = await mediatr.Send(new AlbumQuery(id));
            return Results.Ok(ApiResultExtension.GetApiResult(album));
        });
    }
}