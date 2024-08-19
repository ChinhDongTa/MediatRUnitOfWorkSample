using DongTa.AspireFirst.ApiService.Endpoints;
using DongTa.AspireFirst.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();
app.RegisterAlBumEndpoints();
app.RegisterArtistEndpoints();
app.MapDefaultEndpoints();

app.Run();

//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};
//app.MapGet(pattern: "/weatherforecast", async ([FromServices] IChinookUow uOW) =>
//{
//    var album = await uOW.AlbumRepository.FindByIdAsync(2);
//    return Results.Ok(ApiResultExtension.GetApiResult(album));
//});
//app.MapGet("/weatherforecast", async ([FromServices] IChinookUow uOW) =>
//{
//    //var forecast = Enumerable.Range(1, 5).Select(index =>
//    //    new WeatherForecast
//    //    (
//    //        DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//    //        Random.Shared.Next(-20, 55),
//    //summaries[Random.Shared.Next(summaries.Length)]
//    //    ))
//    //    .ToArray();
//    //return forecast;
//    var album = await uOW.AlbumRepository.FindByIdAsync(2);
//    return Results.Ok(ApiResultExtension.GetApiResult(album));
//});

//record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary) {
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}