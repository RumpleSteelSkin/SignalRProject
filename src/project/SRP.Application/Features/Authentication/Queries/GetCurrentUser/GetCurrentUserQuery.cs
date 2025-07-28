using System.Security.Claims;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace SRP.Application.Features.Authentication.Queries.GetCurrentUser;

public class GetCurrentUserQuery : IRequest<GetCurrentUserQueryResponseDto>
{
    public ClaimsPrincipal? CurrentUser { get; set; }
    public HttpContext? CurrentHttpContext { get; set; }
}