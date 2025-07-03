using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.OrderDetails.Queries.GetCount;

public class OrderDetailGetCountQueryHandler(IOrderDetailRepository orderDetailRepository) : IRequestHandler<OrderDetailGetCountQuery, int>
{
    public async Task<int> Handle(OrderDetailGetCountQuery request, CancellationToken cancellationToken)
    {
        return await orderDetailRepository.CountAsync(cancellationToken: cancellationToken);
    }
}