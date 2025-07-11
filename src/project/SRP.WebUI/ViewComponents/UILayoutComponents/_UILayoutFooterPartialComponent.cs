using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.UILayoutComponents;

public class _UILayoutFooterPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}