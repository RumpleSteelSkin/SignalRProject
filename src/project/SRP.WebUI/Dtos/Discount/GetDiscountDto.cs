namespace SRP.WebUI.Dtos.Discount;

public class GetDiscountDto
{
    public string? Title { get; set; }
    public string? Amount { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
}