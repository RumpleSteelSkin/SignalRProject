using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.Controllers;

public class CategoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}