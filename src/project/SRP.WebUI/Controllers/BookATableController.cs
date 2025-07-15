using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Booking;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class BookATableController(JsonService jsonService) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(CreateBookingDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Booking.Add, dto);
        return RedirectToAction("Index","Default");
    }
}