using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Contacts.Commands.Add;
using SRP.Application.Features.Contacts.Commands.Delete;
using SRP.Application.Features.Contacts.Commands.Update;
using SRP.Application.Features.Contacts.Queries.GetAll;
using SRP.Application.Features.Contacts.Queries.GetById;
using SRP.Application.Features.Discounts.Commands.Add;
using SRP.Application.Features.Discounts.Commands.Delete;
using SRP.Application.Features.Discounts.Commands.StatusChangeById;
using SRP.Application.Features.Discounts.Commands.Update;
using SRP.Application.Features.Discounts.Queries.GetAll;
using SRP.Application.Features.Discounts.Queries.GetAllByStatus;
using SRP.Application.Features.Discounts.Queries.GetById;
using SRP.Application.Features.Discounts.Queries.GetCount;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DiscountsController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(DiscountAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new DiscountDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(DiscountUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new DiscountGetAllQuery()));
    }

    [HttpGet("GetAllByStatus")]
    public async Task<IActionResult> GetAllByStatus(bool status)
    {
        return Ok(await mediator.Send(new DiscountGetAllByStatusQuery { Status = status }));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new DiscountGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new DiscountGetCountQuery()));
    }

    [HttpPost("StatusChangeById")]
    public async Task<IActionResult> StatusChangeById(DiscountStatusChangeByIdCommand command)
    {
        return Ok(await mediator.Send(command));
    }
}