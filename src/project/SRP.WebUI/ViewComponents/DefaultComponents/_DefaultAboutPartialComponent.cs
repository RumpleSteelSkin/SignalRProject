using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultAboutPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}