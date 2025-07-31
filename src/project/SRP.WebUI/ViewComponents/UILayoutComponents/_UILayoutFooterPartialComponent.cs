using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Contact;
using SRP.WebUI.Dtos.SocialMedia;
using SRP.WebUI.Hooks.Jsons;
using SRP.WebUI.ViewModels;

namespace SRP.WebUI.ViewComponents.UILayoutComponents;

public class _UILayoutFooterPartialComponent(JsonService jsonService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(new ContactWithSocialViewModel
        {
            Contacts = await jsonService.GetAllAsync<ResultContactDto>(ApiRoutes.Contact.GetAll),
            SocialMedias = await jsonService.GetAllAsync<ResultSocialMediaDto>(ApiRoutes.SocialMedia.GetAll)
        });
    }
}