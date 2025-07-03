using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Orders.Queries.GetCount;

public class OrderGetCountQueryHandler(IOrderRepository orderRepository) : IRequestHandler<OrderGetCountQuery, int>
{
    public async Task<int> Handle(OrderGetCountQuery request, CancellationToken cancellationToken)
    {
        return await orderRepository.CountAsync(cancellationToken: cancellationToken);
    }
}