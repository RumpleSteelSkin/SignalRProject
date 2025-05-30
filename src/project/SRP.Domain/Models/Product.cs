using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Product : Entity<int>
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
}