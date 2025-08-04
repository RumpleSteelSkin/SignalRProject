using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Contact;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers;

public class ContactController(JsonService jsonService) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await jsonService.GetAllAsync<ResultContactDto>(ApiRoutes.Contact.GetAll));
    }

    public IActionResult Create() => View();

    public async Task<IActionResult> Delete(int id)
    {
        await jsonService.DeleteAsync(ApiRoutes.Contact.Delete, id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        return View(await jsonService.GetByIdAsync<UpdateContactDto>($"{ApiRoutes.Contact.GetById}?id={id}"));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateContactDto dto)
    {
        await jsonService.PostAsync(ApiRoutes.Contact.Add, dto, ModelState);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateContactDto dto)
    {
        await jsonService.UpdateAsync(ApiRoutes.Contact.Update, dto);
        return RedirectToAction(nameof(Index));
    }
}