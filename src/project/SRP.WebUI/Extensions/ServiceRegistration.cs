using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using SRP.Application.Services.JwtServices;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Extensions;

public static class ServiceRegistration
{
    public static IServiceCollection AddWebUiServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        #region Authorization Policy

        var requireAuthorizePolicy = new AuthorizationPolicyBuilder()
            .RequireAuthenticatedUser()
            .Build();

        #endregion

        #region Http Client & Dependencies

        services.AddHttpClient();
        services.AddScoped<JsonService>();
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddHttpContextAccessor();

        #endregion

        #region JWT Token Settings

        services.Configure<CustomTokenOptions>(configuration.GetSection("TokenOptions"));
        var tokenOptions = configuration.GetSection("TokenOptions").Get<CustomTokenOptions>();

        if (tokenOptions is null || string.IsNullOrEmpty(tokenOptions.SecurityKey))
            throw new InvalidOperationException("JWT SecurityKey cannot be null or empty!");

        if (tokenOptions.Audience is null || tokenOptions.Audience.Count == 0)
            throw new InvalidOperationException("JWT Audience cannot be null or empty!");

        #endregion

        #region Authentication Configuration

        services.AddAuthentication("Bearer")
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

        #endregion

        #region MVC Configuration

        services.AddControllersWithViews(opt => { opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy)); });

        #endregion

        return services;
    }
}