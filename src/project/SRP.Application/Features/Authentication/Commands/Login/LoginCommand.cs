using MediatR;
using SRP.Application.Services.JwtServices;

namespace SRP.Application.Features.Authentication.Commands.Login;

public class LoginCommand : IRequest<AccessTokenDto>
{
    public string? UserNameOrEmail { get; set; }
    public string? Password { get; set; }
}