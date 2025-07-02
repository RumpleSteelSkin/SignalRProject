using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.SocialMedia;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class SocialMediaController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultSocialMediaDto>(ApiRoutes.SocialMediaGetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.SocialMediaDelete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateSocialMediaDto>($"{ApiRoutes.SocialMediaGetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSocialMediaDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.SocialMediaAdd, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateSocialMediaDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.SocialMediaUpdate, dto);
        return RedirectToAction(nameof(Index));
    }
}