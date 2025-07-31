using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Category;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class CategoryController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAllAsync<ResultCategoryDto>(ApiRoutes.Category.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Category.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateCategoryDto>($"{ApiRoutes.Category.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryDto dto)
    {
        dto.Status = true;
        await jsonService.PostAsync(ApiRoutes.Category.Add, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateCategoryDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Category.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}