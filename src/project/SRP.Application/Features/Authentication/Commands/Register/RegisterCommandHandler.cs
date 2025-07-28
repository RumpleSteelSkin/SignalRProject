using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SRP.Application.Services.JwtServices;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Commands.Register;

public class RegisterCommandHandler(UserManager<AppUser> userManager, IJwtService jwtService, IMediator mediator)
    : IRequestHandler<RegisterCommand, AccessTokenDto>
{
    public async Task<AccessTokenDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        if (await userManager.FindByEmailAsync(request.Mail!) is not null)
            throw new BusinessException("A user with this email address already exists.");

        if (await userManager.FindByNameAsync(request.Username!) is not null)
            throw new BusinessException("A user with this username already exists.");

        AppUser newUser = new AppUser
        {
            Name = request.Name,
            Surname = request.Surname,
            UserName = request.Username,
            Email = request.Mail
        };

        IdentityResult result = await userManager.CreateAsync(newUser, request.Password!);
        if (!result.Succeeded)
            throw new BusinessException(
                $"User registration failed: {string.Join("; ", result.Errors.Select(e => e.Description))}");

        return await jwtService.CreateTokenAsync(newUser);
    }
}