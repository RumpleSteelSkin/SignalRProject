using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Basket;
using SRP.WebUI.Dtos.Product;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

[AllowAnonymous]
public class MenuController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsyncWithQuery<ResultProductDto>(
            ApiRoutes.Product.GetAllWithNotNullImageAndCategoryNames,
            new Dictionary<string, IEnumerable<string>>
            {
                { "categories", ["Pizza", "Burger", "Pasta", "Fries", "Salad", "Drink", "Sweet"] }
            }
        ));
    }

    public async Task<IActionResult> AddBasket(int id)
    {
        await jsonService.PostAsync(ApiRoutes.Basket.AddWithProductId,
            new CreateBasketWithProductIdDto { ProductId = id });
        return RedirectToAction(nameof(Index));
    }
}