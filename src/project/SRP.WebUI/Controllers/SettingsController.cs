using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Identity;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers
{
    public class SettingsController(JsonService jsonService) : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await jsonService.GetAsync<UserEditDto>(ApiRoutes.Auth.GetCurrentUser));
        }

        [HttpPost]
        public async Task<ActionResult> Index(UserEditDto userEditDto)
        {
            await jsonService.UpdateAsync(ApiRoutes.Auth.UpdateUser, userEditDto);
            return RedirectToAction("Index", "Default");
        }
    }
}