using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Basket;
using SRP.WebUI.Dtos.MenuTables;
using SRP.WebUI.Dtos.Product;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

[AllowAnonymous]
public class MenuController(JsonService jsonService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(int id)
    {
        ViewBag.TableId = id;
        return View(await jsonService.GetAsyncWithQuery<ResultProductDto>(
            ApiRoutes.Product.GetAllWithNotNullImageAndCategoryNames,
            new Dictionary<string, IEnumerable<string>>
            {
                { "categories", ["Pizza", "Burger", "Pasta", "Fries", "Salad", "Drink", "Sweet"] }
            }
        ));
    }

    [HttpPost]
    public async Task<IActionResult> AddBasket(int id, int menuTableId)
    {
        await jsonService.PostAsync(ApiRoutes.Basket.AddWithProductId,
            new CreateBasketWithProductIdDto { ProductId = id, MenuTableId = menuTableId }, ModelState);
        await jsonService.UpdateAsync(ApiRoutes.MenuTable.UpdateState,
            new UpdateStateMenuTableDto { Status = true, Id = menuTableId });
        return RedirectToAction(nameof(Index));
    }
}