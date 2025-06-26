using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.LayoutComponents;

public class _LayoutFooterPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}