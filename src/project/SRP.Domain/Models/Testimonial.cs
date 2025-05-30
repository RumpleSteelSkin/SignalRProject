using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Testimonial : Entity<int>
{
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Comment { get; set; }
    public string? ImageUrl { get; set; }
}