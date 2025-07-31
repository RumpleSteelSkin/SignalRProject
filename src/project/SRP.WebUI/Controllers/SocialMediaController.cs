using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.SocialMedia;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class SocialMediaController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAllAsync<ResultSocialMediaDto>(ApiRoutes.SocialMedia.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.SocialMedia.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateSocialMediaDto>($"{ApiRoutes.SocialMedia.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSocialMediaDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.SocialMedia.Add, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateSocialMediaDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.SocialMedia.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}