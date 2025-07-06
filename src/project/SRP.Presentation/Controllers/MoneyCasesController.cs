using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.MoneyCases.Commands.Add;
using SRP.Application.Features.MoneyCases.Commands.Delete;
using SRP.Application.Features.MoneyCases.Commands.Update;
using SRP.Application.Features.MoneyCases.Queries.GetAll;
using SRP.Application.Features.MoneyCases.Queries.GetById;
using SRP.Application.Features.MoneyCases.Queries.GetCount;
using SRP.Application.Features.MoneyCases.Queries.GetTotalPrice;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoneyCasesController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(MoneyCaseAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new MoneyCaseDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(MoneyCaseUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new MoneyCaseGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new MoneyCaseGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new MoneyCaseGetCountQuery()));
    }

    [HttpGet("GetTotalAmount")]
    public async Task<IActionResult> GetTotalAmount()
    {
        return Ok(await mediator.Send(new MoneyCaseGetTotalPriceQuery()));
    }
}