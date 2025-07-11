using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.UILayoutComponents;

public class _UILayoutHeaderPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}