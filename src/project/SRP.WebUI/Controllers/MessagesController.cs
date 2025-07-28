using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Message;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class MessagesController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultMessageDto>(ApiRoutes.Message.GetAll));
    }

    public IActionResult ClientUserCount()
    {
        return View();
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Message.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateMessageDto>($"{ApiRoutes.Message.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateMessageDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Message.Add, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateMessageDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Message.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}