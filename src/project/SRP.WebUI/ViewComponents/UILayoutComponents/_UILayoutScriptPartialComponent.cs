using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.UILayoutComponents;

public class _UILayoutScriptPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}