using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Notifications;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class NotificationsController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAllAsync<ResultNotificationDto>(ApiRoutes.Notification.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Notification.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateNotificationDto>($"{ApiRoutes.Notification.GetById}?id={id}"));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateStatusById(UpdateStatusNotificationDto options)
    {
        await jsonService.FireAndForgetPutAsync(ApiRoutes.Notification.UpdateStatusById, options);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateNotificationDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Notification.Add, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateNotificationDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Notification.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}