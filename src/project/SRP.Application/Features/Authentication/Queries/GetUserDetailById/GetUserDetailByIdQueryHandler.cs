using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Queries.GetUserDetailById;

public class GetUserDetailByIdQueryHandler(UserManager<AppUser> userManager)
    : IRequestHandler<GetUserDetailByIdQuery, GetUserDetailByIdQueryResponseDto>
{
    public async Task<GetUserDetailByIdQueryResponseDto> Handle(GetUserDetailByIdQuery request,
        CancellationToken cancellationToken)
    {
        var user = await userManager.Users.FirstOrDefaultAsync(x => x.Id == request.UserId,
            cancellationToken: cancellationToken);
        if (user is null)
            throw new Exception("User not found");
        return new GetUserDetailByIdQueryResponseDto
        {
            Mail = user.Email,
            UserName = user.UserName,
            Name = user.Name,
            Surname = user.Surname
        };
    }
}