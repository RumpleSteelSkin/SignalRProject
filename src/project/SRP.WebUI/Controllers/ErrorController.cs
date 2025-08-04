using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        public ActionResult NotFound404Page()
        {
            return View();
        }
    }
}