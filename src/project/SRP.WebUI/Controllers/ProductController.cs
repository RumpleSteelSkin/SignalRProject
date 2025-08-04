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
        return View(await jsonService.GetAllAsync<ResultProductDto>(ApiRoutes.Product.GetAllWithCategoryName));
    }

    public async Task<IActionResult> Create()
    {
        ViewBag.CategoryList =
            await jsonService.GetSelectListAsync<ResultCategoryDto>(ApiRoutes.Category.GetAll, x => x.Name,
                x => x.Id.ToString());
        return View();
    }

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Product.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        ViewBag.CategoryList =
            await jsonService.GetSelectListAsync<ResultCategoryDto>(ApiRoutes.Category.GetAll, x => x.Name,
                x => x.Id.ToString());
        return View(await jsonService.GetByIdAsync<UpdateProductDto>($"{ApiRoutes.Product.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Product.Add, dto, ModelState);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Product.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}