using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Orders.Queries.GetActiveCount;

public class OrderGetActiveCountQueryHandler(IOrderRepository orderRepository)
    : IRequestHandler<OrderGetActiveCountQuery, int>
{
    public async Task<int> Handle(OrderGetActiveCountQuery request, CancellationToken cancellationToken)
    {
        return await orderRepository.CountAsync(x => x.Description == request.Description,
            cancellationToken: cancellationToken);
    }
}