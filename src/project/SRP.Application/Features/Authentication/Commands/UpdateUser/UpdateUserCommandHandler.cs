using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Commands.UpdateUser;

public class UpdateUserCommandHandler(IMapper mapper, UserManager<AppUser> userManager)
    : IRequestHandler<UpdateUserCommand, string>
{
    public async Task<string> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByIdAsync(request.Id.ToString());
        if (user == null)
            throw new NotFoundException("User not found!");
        mapper.Map(request, user);
        await userManager.UpdateAsync(user);
        return "User is updated";
    }
}