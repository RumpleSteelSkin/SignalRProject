using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.UILayoutComponents;

public class _UILayoutNavbarPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}