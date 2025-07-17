using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Notifications.Commands.Add;
using SRP.Application.Features.Notifications.Commands.Delete;
using SRP.Application.Features.Notifications.Commands.Update;
using SRP.Application.Features.Notifications.Commands.UpdateStatusById;
using SRP.Application.Features.Notifications.Queries.GetAll;
using SRP.Application.Features.Notifications.Queries.GetAllByStatus;
using SRP.Application.Features.Notifications.Queries.GetAllCountByStatus;
using SRP.Application.Features.Notifications.Queries.GetById;
using SRP.Application.Features.Notifications.Queries.GetCount;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationsController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(NotificationAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new NotificationDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(NotificationUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }
    
    [HttpPut("UpdateStatusById")]
    public async Task<IActionResult> Update(NotificationUpdateStatusByIdCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new NotificationGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new NotificationGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new NotificationGetCountQuery()));
    }

    [HttpGet("GetAllCountByStatus")]
    public async Task<IActionResult> GetAllCountByStatus(bool status)
    {
        return Ok(await mediator.Send(new NotificationGetAllCountByStatusQuery { Status = status }));
    }

    [HttpGet("GetAllByStatus")]
    public async Task<IActionResult> GetAllByStatus(bool status)
    {
        return Ok(await mediator.Send(new NotificationGetAllByStatusQuery { Status = status }));
    }
    
    
}