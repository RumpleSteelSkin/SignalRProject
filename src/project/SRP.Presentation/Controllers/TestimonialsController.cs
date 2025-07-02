using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Testimonials.Commands.Add;
using SRP.Application.Features.Testimonials.Commands.Delete;
using SRP.Application.Features.Testimonials.Commands.Update;
using SRP.Application.Features.Testimonials.Queries.GetAll;
using SRP.Application.Features.Testimonials.Queries.GetById;
using SRP.Application.Features.Testimonials.Queries.GetCount;

namespace SRP.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IMediator mediator) : ControllerBase
    {
        [HttpPost("Add")]
        public async Task<IActionResult> Add(TestimonialAddCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new TestimonialDeleteCommand { Id = id }));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(TestimonialUpdateCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediator.Send(new TestimonialGetAllQuery()));
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await mediator.Send(new TestimonialGetByIdQuery { Id = id }));
        }

        [HttpGet("GetCount")]
        public async Task<IActionResult> GetCount()
        {
            return Ok(await mediator.Send(new TestimonialGetCountQuery()));
        }
    }
}