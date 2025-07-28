using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SRP.Application.Services.JwtServices;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Commands.Login;

public class LoginCommandHandler(UserManager<AppUser> userManager, IJwtService jwtService)
    : IRequestHandler<LoginCommand, AccessTokenDto>
{
    public async Task<AccessTokenDto> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser? emailUser = await userManager.FindByEmailAsync(request.UserNameOrEmail!) ??
                             await userManager.FindByNameAsync(request.UserNameOrEmail!);

        if (emailUser is null)
            throw new NotFoundException("No user found with the specified email address or username.");

        if (await userManager.CheckPasswordAsync(emailUser, request.Password!) is false)
            throw new BusinessException("Email/UserName or password is not correct. Please try again.");

        return await jwtService.CreateTokenAsync(emailUser);
    }
}