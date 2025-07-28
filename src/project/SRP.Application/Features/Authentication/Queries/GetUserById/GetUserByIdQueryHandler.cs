using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Queries.GetUserById;

public class GetUserByIdQueryHandler(UserManager<AppUser> userManager, IMapper mapper)
    : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResponseDto>
{
    public async Task<GetUserByIdQueryResponseDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<GetUserByIdQueryResponseDto>(
            await userManager.Users.FirstOrDefaultAsync(x => x.Id == request.UserId,
                cancellationToken: cancellationToken));
    }
}