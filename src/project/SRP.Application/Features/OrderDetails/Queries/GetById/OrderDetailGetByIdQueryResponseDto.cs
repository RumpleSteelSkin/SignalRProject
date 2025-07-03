namespace SRP.Application.Features.OrderDetails.Queries.GetById;

public class OrderDetailGetByIdQueryResponseDto
{
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public int Count { get; set; }
    public int OrderID { get; set; }
}