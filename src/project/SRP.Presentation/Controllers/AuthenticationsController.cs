using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Authentication.Commands.Login;
using SRP.Application.Features.Authentication.Commands.Register;

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
}