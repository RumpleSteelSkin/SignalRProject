using MediatR;

namespace SRP.Application.Features.Discounts.Commands.Add;

public class DiscountAddCommand : IRequest<string>
{
    public string? Title { get; set; }
    public string? Amount { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
}