using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Feature;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultSliderPartialComponent(JsonService jsonService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(await jsonService.GetAsync<ResultFeatureDto>(ApiRoutes.Feature.GetAll));
    }
}