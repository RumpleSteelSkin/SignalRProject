using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.MenuTables;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class MenuTablesController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAllAsync<ResultMenuTableDto>(ApiRoutes.MenuTable.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.MenuTable.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateMenuTableDto>($"{ApiRoutes.MenuTable.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateMenuTableDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.MenuTable.Add, dto, ModelState);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateMenuTableDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.MenuTable.Update, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> TableListByStatus()
    {
        return View(await jsonService.GetAllAsync<ResultMenuTableDto>(ApiRoutes.MenuTable.GetAll));
    }
}