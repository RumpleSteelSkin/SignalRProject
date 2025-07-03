namespace SRP.Application.Features.Orders.Queries.GetById;

public class OrderGetByIdQueryResponseDto
{
    public string? TableNumber { get; set; }
    public string? Description { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
}