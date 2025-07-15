using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Basket : Entity<int>
{
    public decimal Price { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }
    public int ProductID { get; set; }
    public Product? Product { get; set; }
    public int MenuTableID { get; set; }
    public MenuTable? MenuTable { get; set; }
}