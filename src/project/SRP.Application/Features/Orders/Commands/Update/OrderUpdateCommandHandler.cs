using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Orders.Commands.Update;

public class OrderUpdateCommandHandler(IOrderRepository orderRepository, IMapper mapper)
    : IRequestHandler<OrderUpdateCommand, string>
{
    public async Task<string> Handle(OrderUpdateCommand request, CancellationToken cancellationToken)
    {
        await orderRepository.UpdateAsync(
            mapper.Map(request,
                await orderRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("Order not updated.")), cancellationToken: cancellationToken);
        return $"Order {request.TableNumber} is updated.";
    }
}