using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Orders.Queries.GetLastPrice;

public class OrderGetLastPriceQueryHandler(IOrderRepository orderRepository)
    : IRequestHandler<OrderGetLastPriceQuery, decimal>
{
    public async Task<decimal> Handle(OrderGetLastPriceQuery request, CancellationToken cancellationToken)
    {
        return (await orderRepository.GetAllAsync(enableTracking: false, include: false,
            cancellationToken: cancellationToken)).OrderByDescending(x => x.Id).First().TotalPrice;
    }
}