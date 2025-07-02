using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.Controllers;

public class SignalRDefaultController: Controller
{
   public IActionResult Index()
   {
      return View();
   }
   
}