using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.LayoutComponents;

public class _LayoutHeaderPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}