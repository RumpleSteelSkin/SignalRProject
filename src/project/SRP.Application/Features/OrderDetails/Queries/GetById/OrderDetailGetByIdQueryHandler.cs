using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.OrderDetails.Queries.GetById;

public class OrderDetailGetByIdQueryHandler(IOrderDetailRepository orderDetailRepository, IMapper mapper)
    : IRequestHandler<OrderDetailGetByIdQuery, OrderDetailGetByIdQueryResponseDto>
{
    public async Task<OrderDetailGetByIdQueryResponseDto> Handle(OrderDetailGetByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<OrderDetailGetByIdQueryResponseDto>(await orderDetailRepository.GetByIdAsync(id: request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}