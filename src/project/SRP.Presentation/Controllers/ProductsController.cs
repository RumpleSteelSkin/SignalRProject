using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Products.Commands.Add;
using SRP.Application.Features.Products.Commands.Delete;
using SRP.Application.Features.Products.Commands.Update;
using SRP.Application.Features.Products.Queries.GetAll;
using SRP.Application.Features.Products.Queries.GetById;

namespace SRP.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IMediator mediator) : ControllerBase
    {
        [HttpPost("Add")]
        public async Task<IActionResult> Add(ProductAddCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new ProductDeleteCommand { Id = id }));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(ProductUpdateCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediator.Send(new ProductGetAllQuery()));
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await mediator.Send(new ProductGetByIdQuery { Id = id }));
        }
    }
}