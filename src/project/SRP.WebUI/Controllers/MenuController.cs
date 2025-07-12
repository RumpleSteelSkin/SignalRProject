using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Product;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers
{
    public class MenuController(JsonService jsonService) : Controller
    {
        public async Task<ActionResult> Index()
        {
            return View(await jsonService.GetAsyncWithQuery<ResultProductDto>(
                ApiRoutes.Product.GetAllWithNotNullImageAndCategoryNames,
                new Dictionary<string, IEnumerable<string>>
                {
                    { "categories", ["Pizza", "Burger", "Pasta", "Fries", "Salad", "Drink", "Sweet"] }
                }
            ));
        }
    }
}