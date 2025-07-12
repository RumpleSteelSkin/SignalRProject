using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Baskets.Commands.Delete;

public class BasketDeleteCommandHandler(IBasketRepository basketRepository) : IRequestHandler<BasketDeleteCommand, string>
{
    public async Task<string> Handle(BasketDeleteCommand request, CancellationToken cancellationToken)
    {
        await basketRepository.HardDeleteAsync(
            await basketRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, include: false,
                enableTracking: false,
                cancellationToken: cancellationToken) ?? throw new NotFoundException("Basket is not found"),
            cancellationToken: cancellationToken);
        return "Basket is deleted";
    }
}