using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Testimonial;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class TestimonialController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultTestimonialDto>(ApiRoutes.TestimonialGetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.TestimonialDelete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateTestimonialDto>($"{ApiRoutes.TestimonialGetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTestimonialDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.TestimonialAdd, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateTestimonialDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.TestimonialUpdate, dto);
        return RedirectToAction(nameof(Index));
    }
}