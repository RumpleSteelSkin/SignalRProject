using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Product;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultOurMenuPartialComponent(JsonService jsonService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(await jsonService.GetAsyncWithQuery<ResultProductDto>(
            ApiRoutes.Product.GetAllWithNotNullImageAndCategoryNames,
            new Dictionary<string, IEnumerable<string>>
            {
                { "categories", ["Pizza", "Burger", "Pasta", "Fries"] }
            }
        ));
    }
}