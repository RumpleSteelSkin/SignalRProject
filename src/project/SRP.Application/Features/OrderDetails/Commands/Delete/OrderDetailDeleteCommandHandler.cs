using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.OrderDetails.Commands.Delete;

public class OrderDetailDeleteCommandHandler(IOrderDetailRepository orderDetailRepository) : IRequestHandler<OrderDetailDeleteCommand, string>
{
    public async Task<string> Handle(OrderDetailDeleteCommand request, CancellationToken cancellationToken)
    {
        await orderDetailRepository.HardDeleteAsync(
            await orderDetailRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, include: false,
                enableTracking: false,
                cancellationToken: cancellationToken) ?? throw new NotFoundException("Order Detail is not found"),
            cancellationToken: cancellationToken);
        return "Order Detail is deleted";
    }
}