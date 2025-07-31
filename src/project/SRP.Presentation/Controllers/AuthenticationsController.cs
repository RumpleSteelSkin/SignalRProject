using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Authentication.Commands.Login;
using SRP.Application.Features.Authentication.Commands.Register;
using SRP.Application.Features.Authentication.Commands.UpdateUser;
using SRP.Application.Features.Authentication.Queries.GetAllUsers;
using SRP.Application.Features.Authentication.Queries.GetCurrentUser;
using SRP.Application.Features.Authentication.Queries.GetUserById;
using SRP.Application.Features.Authentication.Queries.GetUserDetailById;
using SRP.Application.Features.Authentication.Queries.GetUsersByRoleId;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationsController(IMediator mediator) : ControllerBase
{
    [HttpPost("Register")]
    public async Task<IActionResult> Register(RegisterCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpPut("UpdateUser")]
    public async Task<IActionResult> UpdateUser(UpdateUserCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok(await mediator.Send(new GetAllUsersQuery()));
    }

    [HttpGet("GetCurrentUser")]
    public async Task<IActionResult> GetCurrentUser()
    {
        return Ok(await mediator.Send(new GetCurrentUserQuery
            { CurrentUser = User, CurrentHttpContext = HttpContext }));
    }

    [HttpGet("GetUserById")]
    public async Task<IActionResult> GetUserById(int id)
    {
        return Ok(await mediator.Send(new GetUserByIdQuery { UserId = id }));
    }

    [HttpGet("GetUserDetailById")]
    public async Task<IActionResult> GetUserDetailById(int id)
    {
        return Ok(await mediator.Send(new GetUserDetailByIdQuery { UserId = id }));
    }

    [HttpGet("GetUsersByRoleId")]
    public async Task<IActionResult> GetUsersByRoleId(int id)
    {
        return Ok(await mediator.Send(new GetUsersByRoleIdQuery { RoleId = id }));
    }
}