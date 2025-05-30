using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Abouts.Commands.Add;
using SRP.Application.Features.Abouts.Queries.GetAll;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutsController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(AboutAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new AboutGetAllQuery()));
    }
}