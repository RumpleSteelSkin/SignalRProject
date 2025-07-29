using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Bookings.Commands.Add;
using SRP.Application.Features.Bookings.Commands.Delete;
using SRP.Application.Features.Bookings.Commands.StatusChangeById;
using SRP.Application.Features.Bookings.Commands.Update;
using SRP.Application.Features.Bookings.Queries.GetAll;
using SRP.Application.Features.Bookings.Queries.GetById;
using SRP.Application.Features.Bookings.Queries.GetCount;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingsController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(BookingAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpPost("StatusChangeById")]
    public async Task<IActionResult> Add(BookingStatusChangeByIdCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new BookingDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(BookingUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new BookingGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new BookingGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new BookingGetCountQuery()));
    }
}