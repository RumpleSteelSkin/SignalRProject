using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.About;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class AboutController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAllAsync<ResultAboutDto>(ApiRoutes.About.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.About.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateAboutDto>($"{ApiRoutes.About.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateAboutDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.About.Add, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateAboutDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.About.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}