using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.OrderDetails.Queries.GetAll;

public class OrderDetailGetAllQueryHandler(IOrderDetailRepository orderDetailRepository, IMapper mapper)
    : IRequestHandler<OrderDetailGetAllQuery, ICollection<OrderDetailGetAllQueryResponseDto>>
{
    public async Task<ICollection<OrderDetailGetAllQueryResponseDto>> Handle(OrderDetailGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<OrderDetailGetAllQueryResponseDto>>(
            await orderDetailRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}