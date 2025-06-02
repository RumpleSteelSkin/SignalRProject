using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Discounts.Commands.Update;

public class DiscountUpdateCommandHandler(IDiscountRepository discountRepository, IMapper mapper)
    : IRequestHandler<DiscountUpdateCommand, string>
{
    public async Task<string> Handle(DiscountUpdateCommand request, CancellationToken cancellationToken)
    {
        await discountRepository.UpdateAsync(
            mapper.Map(request,
                await discountRepository.GetByIdAsync(id: request.Id, enableTracking: false, include: false,
                    cancellationToken: cancellationToken) ?? throw new NotFoundException("Discount is not found")),
            cancellationToken: cancellationToken);
        return $"Discount {request.Title} is updated.";
    }
}