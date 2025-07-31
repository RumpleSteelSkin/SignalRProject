using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Mail;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers
{
    public class MailController(JsonService jsonService) : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(CreateMailDto dto)
        {
            await jsonService.PostAsync(ApiRoutes.Mail.SendMail, dto);
            return RedirectToAction("Index", "Mail");
        }
    }
}