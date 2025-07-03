using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Orders.Commands.Delete;

public class OrderDeleteCommandHandler(IOrderRepository orderRepository) : IRequestHandler<OrderDeleteCommand, string>
{
    public async Task<string> Handle(OrderDeleteCommand request, CancellationToken cancellationToken)
    {
        await orderRepository.HardDeleteAsync(
            await orderRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, include: false,
                enableTracking: false,
                cancellationToken: cancellationToken) ?? throw new NotFoundException("Order is not found"),
            cancellationToken: cancellationToken);
        return "Order is deleted";
    }
}