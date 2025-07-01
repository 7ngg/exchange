using Exchange.Config;
using Exchange.Entities.Options;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.ConfigureVariables(config);

var app = builder.Build();

app.MapGet("/healthcheck", () => new { exchange = true });

app.Run();
