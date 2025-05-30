using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class SocialMedia : Entity<int>
{
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? Icon { get; set; }
}