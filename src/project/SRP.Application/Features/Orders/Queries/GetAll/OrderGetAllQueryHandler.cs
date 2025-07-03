using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Orders.Queries.GetAll;

public class OrderGetAllQueryHandler(IOrderRepository orderRepository, IMapper mapper)
    : IRequestHandler<OrderGetAllQuery, ICollection<OrderGetAllQueryResponseDto>>
{
    public async Task<ICollection<OrderGetAllQueryResponseDto>> Handle(OrderGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<OrderGetAllQueryResponseDto>>(
            await orderRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}