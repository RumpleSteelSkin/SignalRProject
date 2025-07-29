using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Discounts.Commands.StatusChangeById;

public class DiscountStatusChangeByIdCommandHandler(IDiscountRepository discountRepository)
    : IRequestHandler<DiscountStatusChangeByIdCommand, string>
{
    public async Task<string> Handle(DiscountStatusChangeByIdCommand request, CancellationToken cancellationToken)
    {
        var discount = await discountRepository.GetByIdAsync(request.Id, enableTracking: false, include: false,
            cancellationToken: cancellationToken) ?? throw new NotFoundException("Discount not found");
        discount.Status = request.Status;
        await discountRepository.UpdateAsync(discount, cancellationToken: cancellationToken);
        return "Discount Status Changed";
    }
}