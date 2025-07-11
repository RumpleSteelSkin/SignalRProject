using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultSliderPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}