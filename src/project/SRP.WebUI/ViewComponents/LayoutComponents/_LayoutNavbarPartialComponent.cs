using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.LayoutComponents;

public class _LayoutNavbarPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}