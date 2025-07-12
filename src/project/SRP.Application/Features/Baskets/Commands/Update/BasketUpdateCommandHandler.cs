using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Baskets.Commands.Update;

public class BasketUpdateCommandHandler(IBasketRepository basketRepository, IMapper mapper)
    : IRequestHandler<BasketUpdateCommand, string>
{
    public async Task<string> Handle(BasketUpdateCommand request, CancellationToken cancellationToken)
    {
        await basketRepository.UpdateAsync(
            mapper.Map(request,
                await basketRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("Basket not updated.")), cancellationToken: cancellationToken);
        return $"Basket {request.TotalPrice} is updated.";
    }
}