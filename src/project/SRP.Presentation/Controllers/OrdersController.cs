using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Orders.Commands.Add;
using SRP.Application.Features.Orders.Commands.Delete;
using SRP.Application.Features.Orders.Commands.Update;
using SRP.Application.Features.Orders.Queries.GetActiveCount;
using SRP.Application.Features.Orders.Queries.GetAll;
using SRP.Application.Features.Orders.Queries.GetById;
using SRP.Application.Features.Orders.Queries.GetCount;
using SRP.Application.Features.Orders.Queries.GetLastPrice;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(OrderAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new OrderDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(OrderUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new OrderGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new OrderGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new OrderGetCountQuery()));
    }

    [HttpGet("GetActiveCount")]
    public async Task<IActionResult> GetActiveCount()
    {
        return Ok(await mediator.Send(new OrderGetActiveCountQuery { Description = "Müşteri Masada" }));
    }

    [HttpGet("GetLastPrice")]
    public async Task<IActionResult> GetLastPrice()
    {
        return Ok(await mediator.Send(new OrderGetLastPriceQuery()));
    }
}