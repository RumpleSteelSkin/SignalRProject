using MediatR;

namespace SRP.Application.Features.Discounts.Commands.Update;

public class DiscountUpdateCommand : IRequest<string>
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Amount { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
}