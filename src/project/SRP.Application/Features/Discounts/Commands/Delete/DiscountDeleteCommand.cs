using MediatR;

namespace SRP.Application.Features.Discounts.Commands.Delete;

public class DiscountDeleteCommand : IRequest<string>
{
    public int Id { get; set; }
}