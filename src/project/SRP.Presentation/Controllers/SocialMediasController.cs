using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.SocialMedias.Commands.Add;
using SRP.Application.Features.SocialMedias.Commands.Delete;
using SRP.Application.Features.SocialMedias.Commands.Update;
using SRP.Application.Features.SocialMedias.Queries.GetAll;
using SRP.Application.Features.SocialMedias.Queries.GetById;
using SRP.Application.Features.SocialMedias.Queries.GetCount;

namespace SRP.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IMediator mediator) : ControllerBase
    {
        [HttpPost("Add")]
        public async Task<IActionResult> Add(SocialMediaAddCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new SocialMediaDeleteCommand { Id = id }));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(SocialMediaUpdateCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediator.Send(new SocialMediaGetAllQuery()));
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await mediator.Send(new SocialMediaGetByIdQuery { Id = id }));
        }
        
        [HttpGet("GetCount")]
        public async Task<IActionResult> GetCount()
        {
            return Ok(await mediator.Send(new SocialMediaGetCountQuery()));
        }
    }
}