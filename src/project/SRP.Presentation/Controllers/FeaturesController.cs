using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Features.Commands.Add;
using SRP.Application.Features.Features.Commands.Delete;
using SRP.Application.Features.Features.Commands.Update;
using SRP.Application.Features.Features.Queries.GetAll;
using SRP.Application.Features.Features.Queries.GetById;
using SRP.Application.Features.Features.Queries.GetCount;

namespace SRP.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController(IMediator mediator) : ControllerBase
    {
        [HttpPost("Add")]
        public async Task<IActionResult> Add(FeatureAddCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new FeatureDeleteCommand { Id = id }));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(FeatureUpdateCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediator.Send(new FeatureGetAllQuery()));
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await mediator.Send(new FeatureGetByIdQuery { Id = id }));
        }

        [HttpGet("GetCount")]
        public async Task<IActionResult> GetCount()
        {
            return Ok(await mediator.Send(new FeatureGetCountQuery()));
        }
    }
}