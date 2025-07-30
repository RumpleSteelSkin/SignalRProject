using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Message;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController(JsonService jsonService) : Controller
    {
        // GET: DefaultController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessages()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessages(CreateMessageDto dto)
        {
            await jsonService.PostAsync(ApiRoutes.Message.Add, dto);
            return RedirectToAction("Index");
        }
    }
}