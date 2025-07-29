using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SRP.Application.Services.JwtServices;
using SRP.Domain.Models;
using SRP.Persistence.Contexts;
using SRP.Presentation.Middlewares;

namespace SRP.Presentation.Extensions;

public static class ServiceRegistration
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        #region Default API Services

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        #endregion

        #region JWT Token Services

        services.Configure<CustomTokenOptions>(configuration.GetSection("TokenOptions"));

        services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;
            })
            .AddEntityFrameworkStores<BaseDbContext>()
            .AddDefaultTokenProviders();

        var tokenOptions = configuration.GetSection("TokenOptions").Get<CustomTokenOptions>();

        if (tokenOptions is null || string.IsNullOrEmpty(tokenOptions.SecurityKey))
            throw new InvalidOperationException("JWT SecurityKey cannot be null or empty!");

        if (tokenOptions.Audience is null || tokenOptions.Audience.Count == 0)
            throw new InvalidOperationException("JWT Audience cannot be null or empty!");

        services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = tokenOptions.Issuer,
                    ValidAudience = tokenOptions.Audience[0],
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))
                };
                opt.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Cookies["access_token"];
                        if (!string.IsNullOrEmpty(accessToken))
                        {
                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };
            });
        #endregion

        #region Redis Services

        // var redisConfig = configuration.GetSection("RedisConfigurations");
        // services.AddStackExchangeRedisCache(opt =>
        // {
        //     opt.Configuration = redisConfig[configuration.GetSection("ConnectionStringsSelector").Get<string>()!];
        //     opt.InstanceName = redisConfig["InstanceName"];
        // });

        #endregion

        #region CORS Services

        services.AddCors(opt =>
        {
            opt.AddPolicy("AllowAll", policy =>
                policy.AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed((host) => true)
                    .AllowCredentials());
        });

        #endregion

        #region SignalR Services

        services.AddSignalR();

        #endregion

        #region Global Exception Handling Services

        services.AddExceptionHandler<HttpExceptionHandler>();

        #endregion

        #region JSON Cycle Disable

        services.AddControllersWithViews()
            .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

        #endregion

        return services;
    }
}