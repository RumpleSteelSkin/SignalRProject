using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.OrderDetails.Commands.Add;

public class OrderDetailAddCommandHandler(IOrderDetailRepository orderDetailRepository, IMapper mapper)
    : IRequestHandler<OrderDetailAddCommand, string>
{
    public async Task<string> Handle(OrderDetailAddCommand request, CancellationToken cancellationToken)
    {
        await orderDetailRepository.AddAsync(mapper.Map<OrderDetail>(request), cancellationToken);
        return $"OrderDetail {request.TotalPrice} has been successfully added.";
    }
}