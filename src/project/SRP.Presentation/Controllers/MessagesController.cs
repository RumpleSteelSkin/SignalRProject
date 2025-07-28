using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Messages.Commands.Add;
using SRP.Application.Features.Messages.Commands.Delete;
using SRP.Application.Features.Messages.Commands.Update;
using SRP.Application.Features.Messages.Queries.GetAll;
using SRP.Application.Features.Messages.Queries.GetById;
using SRP.Application.Features.Messages.Queries.GetCount;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessagesController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(MessageAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new MessageDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(MessageUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new MessageGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new MessageGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new MessageGetCountQuery()));
    }
}