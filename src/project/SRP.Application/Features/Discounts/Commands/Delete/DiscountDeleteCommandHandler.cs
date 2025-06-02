using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Discounts.Commands.Delete;

public class DiscountDeleteCommandHandler(IDiscountRepository discountRepository)
    : IRequestHandler<DiscountDeleteCommand, string>
{
    public async Task<string> Handle(DiscountDeleteCommand request, CancellationToken cancellationToken)
    {
        await discountRepository.HardDeleteAsync(
            await discountRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, enableTracking: false,
                include: false, cancellationToken: cancellationToken) ??
            throw new NotFoundException("Discount not found."), cancellationToken: cancellationToken);
        return "Discount is deleted.";
    }
}