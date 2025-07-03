using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.OrderDetails.Commands.Update;

public class OrderDetailUpdateCommandHandler(IOrderDetailRepository orderDetailRepository, IMapper mapper)
    : IRequestHandler<OrderDetailUpdateCommand, string>
{
    public async Task<string> Handle(OrderDetailUpdateCommand request, CancellationToken cancellationToken)
    {
        await orderDetailRepository.UpdateAsync(
            mapper.Map(request,
                await orderDetailRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("Order Detail not updated.")), cancellationToken: cancellationToken);
        return $"Order Detail {request.TotalPrice} is updated.";
    }
}