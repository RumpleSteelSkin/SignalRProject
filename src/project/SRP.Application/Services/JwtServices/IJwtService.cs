using SRP.Domain.Models;

namespace SRP.Application.Services.JwtServices;

public interface IJwtService
{
    Task<AccessTokenDto> CreateTokenAsync(AppUser user);
}