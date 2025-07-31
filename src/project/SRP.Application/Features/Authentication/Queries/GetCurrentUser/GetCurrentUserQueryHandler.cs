using System.Security.Authentication;
using System.Security.Claims;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Queries.GetCurrentUser;

public class GetCurrentUserQueryHandler(UserManager<AppUser> userManager, IMapper mapper)
    : IRequestHandler<GetCurrentUserQuery, GetCurrentUserQueryResponseDto>
{
    public async Task<GetCurrentUserQueryResponseDto> Handle(GetCurrentUserQuery request,
        CancellationToken cancellationToken)
    {
        if (request.CurrentUser is null)
            throw new AuthenticationException("User context is null. Make sure the user is authenticated.");

        if (request.CurrentHttpContext is null)
            throw new NotFoundException("HTTP Context is null. Ensure the request has a valid context.");

        var userId = request.CurrentUser.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            throw new AuthenticationException("User ID claim is missing. Ensure the user is authenticated.");


        var user = await userManager.Users.FirstOrDefaultAsync(x => x.Id == Convert.ToInt32(userId),
            cancellationToken: cancellationToken);

        var response = new GetCurrentUserQueryResponseDto
        {
            Id = userId,
            Username = user!.UserName,
            Mail = user.Email,
            Name = user.Name,
            Surname = user.Surname,
        };

        return await Task.FromResult(response);
    }
}