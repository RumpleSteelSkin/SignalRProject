﻿using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.ViewComponents.LayoutComponents;

public class _LayoutScriptPartialComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}