using Microsoft.AspNetCore.Mvc;

namespace SRP.WebUI.Controllers;

public class StatisticController: Controller
{
   public IActionResult Index()
   {
      return View();
   }
   
}