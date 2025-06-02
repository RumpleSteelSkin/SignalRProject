using System.ComponentModel.DataAnnotations.Schema;
using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Order : Entity<int>
{
    public string? TableNumber { get; set; }
    public string? Description { get; set; }

    [Column(TypeName = "Date")] public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
    public List<OrderDetail>? OrderDetails { get; set; }
}