using MediatR;

namespace SRP.Application.Features.Products.Commands.Add;

public class ProductAddCommand : IRequest<string>
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public int CategoryID { get; set; }
}