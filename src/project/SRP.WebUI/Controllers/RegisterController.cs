using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Identity;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class RegisterController(JsonService jsonService) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(RegisterDto registerDto)
    {
        await jsonService.PostAsync(ApiRoutes.Auth.Register, registerDto);
        return View();
    }
}