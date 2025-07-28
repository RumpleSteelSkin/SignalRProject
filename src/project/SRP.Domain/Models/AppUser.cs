using Microsoft.AspNetCore.Identity;

namespace SRP.Domain.Models;

public class AppUser : IdentityUser<int>
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
}