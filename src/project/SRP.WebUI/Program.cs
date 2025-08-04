using SRP.WebUI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWebUiServices(builder.Configuration);

var app = builder.Build();

app.AddWebUiApp();