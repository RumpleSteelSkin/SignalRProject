using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.About;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultAboutPartialComponent(JsonService jsonService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(await jsonService.GetAllAsync<ResultAboutDto>(ApiRoutes.About.GetAll));
    }
}