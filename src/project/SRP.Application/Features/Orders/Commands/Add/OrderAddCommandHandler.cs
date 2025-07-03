using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Orders.Commands.Add;

public class OrderAddCommandHandler(IOrderRepository orderRepository, IMapper mapper)
    : IRequestHandler<OrderAddCommand, string>
{
    public async Task<string> Handle(OrderAddCommand request, CancellationToken cancellationToken)
    {
        await orderRepository.AddAsync(mapper.Map<Order>(request), cancellationToken);
        return $"Order {request.TotalPrice} has been successfully added.";
    }
}