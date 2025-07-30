using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using SRP.Application.Services.JwtServices;
using SRP.WebUI.Hooks.Jsons;

var builder = WebApplication.CreateBuilder(args);

var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

builder.Services.AddHttpClient();
builder.Services.AddScoped<JsonService>();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpContextAccessor();


builder.Services.Configure<CustomTokenOptions>(builder.Configuration.GetSection("TokenOptions"));
var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<CustomTokenOptions>();
if (tokenOptions is null || string.IsNullOrEmpty(tokenOptions.SecurityKey))
    throw new InvalidOperationException("JWT SecurityKey cannot be null or empty!");

if (tokenOptions.Audience is null || tokenOptions.Audience.Count == 0)
    throw new InvalidOperationException("JWT Audience cannot be null or empty!");

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience[0],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))
        };

        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                var accessToken = context.HttpContext.Request.Cookies["access_token"];
                if (!string.IsNullOrEmpty(accessToken))
                {
                    context.Token = accessToken;
                }

                return Task.CompletedTask;
            },
            OnChallenge = context =>
            {
                context.HandleResponse();
                context.Response.StatusCode = 302;
                context.Response.Headers.Location = "/Login/Index";

                return Task.CompletedTask;
            }
        };
    });


builder.Services.AddControllersWithViews(opt => { opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy)); });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();