using MediatR;

namespace SRP.Application.Features.Baskets.Commands.AddWithProductId;

public class BasketAddWithProductIdCommand : IRequest<string>
{
    public int ProductId { get; set; }
}