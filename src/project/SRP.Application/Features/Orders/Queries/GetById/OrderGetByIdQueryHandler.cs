using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Orders.Queries.GetById;

public class OrderGetByIdQueryHandler(IOrderRepository orderRepository, IMapper mapper)
    : IRequestHandler<OrderGetByIdQuery, OrderGetByIdQueryResponseDto>
{
    public async Task<OrderGetByIdQueryResponseDto> Handle(OrderGetByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<OrderGetByIdQueryResponseDto>(await orderRepository.GetByIdAsync(id: request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}