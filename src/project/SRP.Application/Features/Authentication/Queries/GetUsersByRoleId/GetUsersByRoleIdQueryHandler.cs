using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Queries.GetUsersByRoleId;

public class GetUsersByRoleIdQueryHandler(
    UserManager<AppUser> userManager,
    RoleManager<AppRole> roleManager,
    IMapper mapper) : IRequestHandler<GetUsersByRoleIdQuery, ICollection<GetUsersByRoleIdQueryResponseDto>>
{
    public async Task<ICollection<GetUsersByRoleIdQueryResponseDto>> Handle(GetUsersByRoleIdQuery request,
        CancellationToken cancellationToken)
    {
        if (request.RoleId == null)
            throw new ValidationException("RoleId cannot be null.");

        var role = await roleManager.FindByIdAsync(request.RoleId.ToString()!);
        if (role == null)
            throw new NotFoundException("Role not found.");

        return mapper.Map<ICollection<GetUsersByRoleIdQueryResponseDto>>(
            await userManager.GetUsersInRoleAsync(role.Name!));
    }
}