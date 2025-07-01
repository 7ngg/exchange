var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/healthcheck", () => new { exchange = true });

app.Run();