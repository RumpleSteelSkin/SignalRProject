using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Queries.GetAllUsers;

public class GetAllUsersQueryHandler(UserManager<AppUser> userManager, IMapper mapper)
    : IRequestHandler<GetAllUsersQuery, ICollection<GetAllUsersQueryResponseDto>>
{
    public async Task<ICollection<GetAllUsersQueryResponseDto>> Handle(GetAllUsersQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<GetAllUsersQueryResponseDto>>(
            await userManager.Users.ToListAsync(cancellationToken: cancellationToken));
    }
}