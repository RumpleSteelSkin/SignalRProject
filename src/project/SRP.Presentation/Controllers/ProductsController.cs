using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Products.Commands.Add;
using SRP.Application.Features.Products.Commands.Delete;
using SRP.Application.Features.Products.Commands.Update;
using SRP.Application.Features.Products.Queries.GetAll;
using SRP.Application.Features.Products.Queries.GetAllWithCategoryName;
using SRP.Application.Features.Products.Queries.GetAllWithNotNullImageAndCategoryNames;
using SRP.Application.Features.Products.Queries.GetById;
using SRP.Application.Features.Products.Queries.GetCount;
using SRP.Application.Features.Products.Queries.GetCountWithCategoryName;
using SRP.Application.Features.Products.Queries.GetNameByMaxPrice;
using SRP.Application.Features.Products.Queries.GetNameByMinPrice;
using SRP.Application.Features.Products.Queries.GetTotalAverageCategoryName;
using SRP.Application.Features.Products.Queries.GetTotalAveragePrice;

namespace SRP.Presentation.Controllers;

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

    [HttpGet("GetAllWithCategoryName")]
    public async Task<IActionResult> GetAllWithCategoryName()
    {
        return Ok(await mediator.Send(new ProductGetAllWithCategoryNameQuery()));
    }

    [HttpGet("GetCount")]
    public async Task<IActionResult> GetCount()
    {
        return Ok(await mediator.Send(new ProductGetCountQuery()));
    }

    [HttpGet("GetCountWithCategoryNameOfDrink")]
    public async Task<IActionResult> GetCountWithCategoryNameOfDrink()
    {
        return Ok(await mediator.Send(new ProductGetCountWithCategoryName { CategoryName = "Drink" }));
    }

    [HttpGet("GetCountWithCategoryNameOfHamburger")]
    public async Task<IActionResult> GetCountWithCategoryNameOfHamburger()
    {
        return Ok(await mediator.Send(new ProductGetCountWithCategoryName { CategoryName = "Hamburger" }));
    }

    [HttpGet("GetTotalAveragePrice")]
    public async Task<IActionResult> GetTotalAveragePrice()
    {
        return Ok(await mediator.Send(new ProductGetTotalAveragePriceQuery()));
    }

    [HttpGet("GetNameByMaxPrice")]
    public async Task<IActionResult> GetNameByMaxPrice()
    {
        return Ok(await mediator.Send(new ProductGetNameByMaxPriceQuery()));
    }

    [HttpGet("GetNameByMinPrice")]
    public async Task<IActionResult> GetNameByMinPrice()
    {
        return Ok(await mediator.Send(new ProductGetNameByMinPriceQuery()));
    }

    [HttpGet("GetTotalAverageCategoryNameQuery")]
    public async Task<IActionResult> GetTotalAveragePriceWithCategoryName()
    {
        return Ok(await mediator.Send(new ProductGetTotalAverageCategoryNameQuery { CategoryName = "Burger" }));
    }

    [HttpGet("GetAllWithNotNullImageAndCategoryNames")]
    public async Task<IActionResult> GetAllWithNotNullImageAndCategoryNames([FromQuery] string[]? categories = null)
    {
        return Ok(await mediator.Send(new ProductGetAllWithNotNullImageAndCategoryNamesQuery { CategoryNames = categories }));
    }
}