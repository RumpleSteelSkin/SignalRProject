using SRP.Domain.Models;

namespace SRP.Application.Features.Baskets.Queries.GetAll;

public class BasketGetAllQueryResponseDto
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public decimal Count { get; set; }
    public decimal TotalPrice { get; set; }
    public Product? Product { get; set; }
    public MenuTable? MenuTable { get; set; }
}