using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Abouts.Commands.Add;
using SRP.Application.Features.Abouts.Commands.Delete;
using SRP.Application.Features.Abouts.Commands.Update;
using SRP.Application.Features.Abouts.Queries.GetAll;
using SRP.Application.Features.Abouts.Queries.GetById;

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

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new AboutDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(AboutUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new AboutGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new AboutGetByIdQuery { Id = id }));
    }
}