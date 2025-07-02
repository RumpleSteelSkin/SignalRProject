using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Testimonial;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class TestimonialController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAsync<ResultTestimonialDto>(ApiRoutes.Testimonial.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Testimonial.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateTestimonialDto>($"{ApiRoutes.Testimonial.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTestimonialDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Testimonial.Add, dto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateTestimonialDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Testimonial.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}