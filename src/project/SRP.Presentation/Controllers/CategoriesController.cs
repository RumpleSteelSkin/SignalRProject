using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Categories.Commands.Add;
using SRP.Application.Features.Categories.Commands.Delete;
using SRP.Application.Features.Categories.Commands.Update;
using SRP.Application.Features.Categories.Queries.GetActiveCount;
using SRP.Application.Features.Categories.Queries.GetAll;
using SRP.Application.Features.Categories.Queries.GetById;
using SRP.Application.Features.Categories.Queries.GetCount;
using SRP.Application.Features.Categories.Queries.GetPassiveCount;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController(IMediator mediator) : ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CategoryAddCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await mediator.Send(new CategoryDeleteCommand { Id = id }));
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(CategoryUpdateCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new CategoryGetAllQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await mediator.Send(new CategoryGetByIdQuery { Id = id }));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new CategoryGetCountQuery()));
    }

    [HttpGet("GetActiveCount")]
    public async Task<IActionResult> GetActiveCount()
    {
        return Ok(await mediator.Send(new CategoryGetActiveCountQuery()));
    }

    [HttpGet("GetPassiveCount")]
    public async Task<IActionResult> GetPassiveCount()
    {
        return Ok(await mediator.Send(new CategoryGetPassiveCountQuery()));
    }
}