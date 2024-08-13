using DongTa.DataAccess.Repositories;
using DongTa.Domain.Interfaces;
using ErpBhxhGialai.ConfigurationService.Classes;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using DongTa.DataAccessMediatR;
using DongTa.DataAccessDapper;

namespace DongTa.ApiServer.Helpers;

public static class ConfigService {

    public static async void RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
        {
            options.SerializerOptions.PropertyNameCaseInsensitive = true;
            options.SerializerOptions.PropertyNamingPolicy = null;
            options.SerializerOptions.WriteIndented = true;
            options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
        //Configuration Connection string
        await RegisterConnectionServices.Configure();
        builder.Services.AddDbContext<DataAccess.Contexts.ChinookContext>(
            option => option.UseSqlServer(
            AppConnections.Instance.Other, o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
            );
        //Add MediatR
        builder.Services.RegisterMediatR();

        builder.Services.AddScoped<IChinookUow, ChinookUow>();
        builder.Services.AddScoped<IDongTaDapper, DongTaDapper>();
    }
}