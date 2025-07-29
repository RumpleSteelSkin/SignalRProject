using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Booking;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class BookingController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultBookingDto>(ApiRoutes.Booking.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Booking.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateBookingDto>($"{ApiRoutes.Booking.GetById}?id={id}"));
    }

    public async Task<IActionResult> StatusChangeById(StatusChangeByIdBookingDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Booking.StatusChangeById, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBookingDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Booking.Add, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateBookingDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Booking.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}