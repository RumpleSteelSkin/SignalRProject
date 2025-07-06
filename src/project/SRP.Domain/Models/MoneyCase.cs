using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class MoneyCase : Entity<int>
{
    public decimal TotalAmount { get; set; }
}