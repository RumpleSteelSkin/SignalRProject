using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Category;
using SRP.WebUI.Dtos.Product;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class ProductController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultProductDto>(ApiRoutes.ProductGetAllWithCategoryName));
    }

    public async Task<IActionResult> Create()
    {
        ViewBag.CategoryList =
            await jsonService.GetSelectListAsync<ResultCategoryDto>(ApiRoutes.CategoryGetAll, x => x.Name,
                x => x.Id.ToString());
        return View();
    }

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.ProductDelete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        ViewBag.CategoryList =
            await jsonService.GetSelectListAsync<ResultCategoryDto>(ApiRoutes.CategoryGetAll, x => x.Name,
                x => x.Id.ToString());
        return View(await jsonService.GetByIdAsync<UpdateProductDto>($"{ApiRoutes.ProductGetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.ProductAdd, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.ProductUpdate, dto);
        return RedirectToAction(nameof(Index));
    }
}