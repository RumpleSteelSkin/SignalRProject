using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.MenuTables.Commands.Add;
using SRP.Application.Features.MenuTables.Commands.Delete;
using SRP.Application.Features.MenuTables.Commands.Update;
using SRP.Application.Features.MenuTables.Commands.UpdateState;
using SRP.Application.Features.MenuTables.Queries.GetAll;
using SRP.Application.Features.MenuTables.Queries.GetById;
using SRP.Application.Features.MenuTables.Queries.GetCount;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MenuTablesController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(MenuTableAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new MenuTableDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(MenuTableUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }
    
    [HttpPut("UpdateState")]
    public async Task<IActionResult> UpdateState(MenuTableUpdateStateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new MenuTableGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new MenuTableGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new MenuTableGetCountQuery()));
    }
}