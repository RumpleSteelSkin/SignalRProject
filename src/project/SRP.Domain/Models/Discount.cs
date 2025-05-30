using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Discount : Entity<int>
{
    public string? Title { get; set; }
    public string? Amount { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}