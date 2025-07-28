using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SRP.Domain.Models;

namespace SRP.Application.Services.JwtServices;

public class JwtService(UserManager<AppUser> userManager, IOptions<CustomTokenOptions> options)
    : IJwtService
{
    private readonly CustomTokenOptions _customTokenOptions = options.Value;

    public async Task<AccessTokenDto> CreateTokenAsync(AppUser user)
    {
        var accessTokenExpiration = DateTime.Now.AddMinutes(_customTokenOptions.AccessTokenExpiration);
        return new AccessTokenDto
        {
            Token = new JwtSecurityTokenHandler().WriteToken(new JwtSecurityToken(
                issuer: _customTokenOptions.Issuer,
                audience: _customTokenOptions.Audience?[0],
                expires: accessTokenExpiration,
                signingCredentials: new(GetSecurityKey(_customTokenOptions.SecurityKey),
                    SecurityAlgorithms.HmacSha512Signature),
                claims: await GetClaims(user)
            )),
            TokenExpiration = accessTokenExpiration
        };
    }


    private async Task<List<Claim>> GetClaims(AppUser user)
    {
        List<Claim> claimList =
        [
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Email, user.Email ?? string.Empty)
        ];
        IList<string> roles = await userManager.GetRolesAsync(user);
        if (roles.Count > 0)
            claimList.AddRange(roles.Select(x => new Claim(ClaimTypes.Role, x)));
        return claimList;
    }

    private static SecurityKey GetSecurityKey(string? key)
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key ?? string.Empty));
    }
}