using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultOfferPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}