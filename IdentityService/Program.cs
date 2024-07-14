using IdentityService.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDataContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();