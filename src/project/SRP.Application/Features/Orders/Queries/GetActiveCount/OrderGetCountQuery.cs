using MediatR;

namespace SRP.Application.Features.Orders.Queries.GetActiveCount;

public class OrderGetActiveCountQuery : IRequest<int>
{
    public string? Description { get; set; }
}