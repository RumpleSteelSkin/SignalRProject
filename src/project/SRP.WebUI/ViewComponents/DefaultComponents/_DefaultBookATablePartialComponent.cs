using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultBookATablePartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}