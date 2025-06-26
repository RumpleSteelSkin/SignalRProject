using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Category;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class CategoryController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultCategoryDto>(ApiRoutes.CategoryGetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.CategoryDelete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateCategoryDto>($"{ApiRoutes.CategoryGetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryDto dto)
    {
        dto.Status = true;
        await jsonService.PostAsync(ApiRoutes.CategoryAdd, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateCategoryDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.CategoryUpdate, dto);
        return RedirectToAction(nameof(Index));
    }
}