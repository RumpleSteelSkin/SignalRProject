using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Feature;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class FeatureController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultFeatureDto>(ApiRoutes.FeatureGetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.FeatureDelete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateFeatureDto>($"{ApiRoutes.FeatureGetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateFeatureDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.FeatureAdd, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateFeatureDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.FeatureUpdate, dto);
        return RedirectToAction(nameof(Index));
    }
}