using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.LayoutComponents;

public class _LayoutSidebarPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}