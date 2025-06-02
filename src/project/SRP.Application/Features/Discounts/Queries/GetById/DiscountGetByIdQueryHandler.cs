using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Discounts.Queries.GetById;

public class DiscountGetByIdQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
    : IRequestHandler<DiscountGetByIdQuery, DiscountGetByIdQueryResponseDto>
{
    public async Task<DiscountGetByIdQueryResponseDto> Handle(DiscountGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<DiscountGetByIdQueryResponseDto>(await discountRepository.GetByIdAsync(id: request.Id,
            ignoreQueryFilters: true, enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}