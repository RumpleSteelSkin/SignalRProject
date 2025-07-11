using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Testimonial;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.ViewComponents.DefaultComponents;

public class _DefaultTestimonialPartialComponent(JsonService jsonService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(await jsonService.GetAsync<ResultTestimonialDto>(ApiRoutes.Testimonial.GetAll));
    }
}
