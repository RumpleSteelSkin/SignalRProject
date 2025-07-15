using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Baskets.Commands.Add;
using SRP.Application.Features.Baskets.Commands.AddWithProductId;
using SRP.Application.Features.Baskets.Commands.Delete;
using SRP.Application.Features.Baskets.Commands.Update;
using SRP.Application.Features.Baskets.Queries.GetAll;
using SRP.Application.Features.Baskets.Queries.GetById;
using SRP.Application.Features.Baskets.Queries.GetByMenuTableNumber;
using SRP.Application.Features.Baskets.Queries.GetCount;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BasketsController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(BasketAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new BasketDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(BasketUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new BasketGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new BasketGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new BasketGetCountQuery()));
    }

    [HttpGet("GetByMenuTableNumber")]
    public async Task<IActionResult> GetCount(int menuTableId)
    {
        return Ok(await mediator.Send(new BasketGetByMenuTableNumberQuery { MenuTableID = menuTableId }));
    }

    [HttpPost("AddWithProductId")]
    public async Task<IActionResult> AddWithProductId(BasketAddWithProductIdCommand command)
    {
        return Ok(await mediator.Send(command));
    }
}