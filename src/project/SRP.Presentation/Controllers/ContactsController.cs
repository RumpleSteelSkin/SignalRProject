using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Contacts.Commands.Add;
using SRP.Application.Features.Contacts.Commands.Delete;
using SRP.Application.Features.Contacts.Commands.Update;
using SRP.Application.Features.Contacts.Queries.GetAll;
using SRP.Application.Features.Contacts.Queries.GetById;
using SRP.Application.Features.Contacts.Queries.GetCount;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(ContactAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new ContactDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(ContactUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new ContactGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new ContactGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new ContactGetCountQuery()));
    }
}