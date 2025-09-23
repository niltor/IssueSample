var builder = DistributedApplication.CreateBuilder(args);


var migration = builder.AddProject<Projects.MigrationService>("migrationservice");

var apiService = builder.AddProject<Projects.AspireWatch_ApiService>("apiservice")
    .WaitForCompletion(migration)
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.AspireWatch_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);


builder.Build().Run();
