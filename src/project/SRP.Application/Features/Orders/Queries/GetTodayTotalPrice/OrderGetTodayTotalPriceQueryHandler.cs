using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Orders.Queries.GetTodayTotalPrice;

public class OrderGetTodayTotalPriceQueryHandler(IOrderRepository orderRepository)
    : IRequestHandler<OrderGetTodayTotalPriceQuery, decimal>
{
    public async Task<decimal> Handle(OrderGetTodayTotalPriceQuery request, CancellationToken cancellationToken)
    {
        return (await orderRepository.GetAllAsync(x => x.OrderDate == DateTime.Now.Date, enableTracking: false,
            include: false, cancellationToken: cancellationToken)).Select(x => x.TotalPrice).Sum();
    }
}