using SRP.WebUI.Dtos.Contact;
using SRP.WebUI.Dtos.SocialMedia;

namespace SRP.WebUI.ViewModels;

public class ContactWithSocialViewModel
{
    public ICollection<ResultContactDto>? Contacts { get; set; }
    public ICollection<ResultSocialMediaDto>? SocialMedias { get; set; }
}