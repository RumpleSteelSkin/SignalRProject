using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Discount;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class DiscountController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultDiscountDto>(ApiRoutes.Discount.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Discount.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateDiscountDto>($"{ApiRoutes.Discount.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDiscountDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Discount.Add, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateDiscountDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Discount.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}