namespace SRP.Application.Features.Products.Queries.GetAllWithNotNullImageAndCategoryNames;

public class ProductGetAllWithNotNullImageAndCategoryNamesQueryResponseDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
    public string? CategoryName { get; set; }
}