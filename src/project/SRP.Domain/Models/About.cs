using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class About : Entity<int>
{
    public string? ImageUrl { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}