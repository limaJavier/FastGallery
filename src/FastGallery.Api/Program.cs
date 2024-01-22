using FastGallery.Application;
using FastGallery.Infrastructure;
using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints().SwaggerDocument();

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

app.UseFastEndpoints();
app.UseSwaggerGen();
app.Run();