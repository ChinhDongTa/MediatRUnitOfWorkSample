var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.DongTa_AspireFirst_ApiService>("apiservice");
//builder.AddProject<>("apiservice");

builder.AddProject<Projects.DongTa_AspireFirst_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();