namespace SRP.Application.Features.Orders.Queries.GetAll;

public class OrderGetAllQueryResponseDto
{
    public int Id { get; set; }
    public string? TableNumber { get; set; }
    public string? Description { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
}