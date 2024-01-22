using FastGallery.Application;
using FastGallery.Infrastructure;
using FastEndpoints;
using FastEndpoints.Swagger;
using FastGallery.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPresentation();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.UseAuthentication();
app.UseFastEndpoints();
app.UseSwaggerGen();
app.Run();