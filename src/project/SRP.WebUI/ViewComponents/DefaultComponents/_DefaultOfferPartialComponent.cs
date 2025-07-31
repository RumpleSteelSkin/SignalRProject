using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Discount;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultOfferPartialComponent (JsonService jsonService) :ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(await jsonService.GetAllAsync<ResultDiscountDto>($"{ApiRoutes.Discount.GetAllByStatus}?status={true}"));
    }
}