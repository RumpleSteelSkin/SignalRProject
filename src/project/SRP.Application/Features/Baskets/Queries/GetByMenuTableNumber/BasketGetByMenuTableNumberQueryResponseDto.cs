using SRP.Domain.Models;

namespace SRP.Application.Features.Baskets.Queries.GetByMenuTableNumber;

public class BasketGetByMenuTableNumberQueryResponseDto
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }
    public int ProductID { get; set; }
    public string? ProductName { get; set; }
    public int MenuTableID { get; set; }
}