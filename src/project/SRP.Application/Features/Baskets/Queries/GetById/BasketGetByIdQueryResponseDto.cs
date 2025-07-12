using SRP.Domain.Models;

namespace SRP.Application.Features.Baskets.Queries.GetById;

public class BasketGetByIdQueryResponseDto
{
    public decimal Price { get; set; }
    public decimal Count { get; set; }
    public decimal TotalPrice { get; set; }
    public Product? Product { get; set; }
    public MenuTable? MenuTable { get; set; }
}