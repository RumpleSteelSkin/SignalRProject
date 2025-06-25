using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.Controllers;

public class AdminLayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}