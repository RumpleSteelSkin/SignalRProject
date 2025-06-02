using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Category : Entity<int>
{
    public required string Name { get; set; }
    public List<Product>? Products { get; set; }
}