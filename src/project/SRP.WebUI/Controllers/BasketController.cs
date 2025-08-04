using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Basket;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

[AllowAnonymous]
public class BasketController(JsonService jsonService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(int id)
    {
        return View(await jsonService.GetAllAsync<ResultBasketDto>($"{ApiRoutes.Basket.GetByMenuTableNumber}?menuTableId={id}"));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Basket.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateBasketDto>($"{ApiRoutes.Basket.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBasketDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Basket.Add, dto, ModelState);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateBasketDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Basket.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}