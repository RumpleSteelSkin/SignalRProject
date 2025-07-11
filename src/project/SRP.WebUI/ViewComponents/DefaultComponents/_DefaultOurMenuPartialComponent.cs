using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultOurMenuPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}