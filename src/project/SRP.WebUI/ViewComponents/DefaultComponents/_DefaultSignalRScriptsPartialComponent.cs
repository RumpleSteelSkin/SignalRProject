using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultSignalRScriptsPartialComponent(JsonService jsonService) : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}