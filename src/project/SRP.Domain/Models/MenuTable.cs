using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class MenuTable : Entity<int>
{
    public string? Name { get; set; }
    public List<Basket>? Baskets { get; set; }
}