using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Discounts.Queries.GetAll;

public class DiscountGetAllQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
    : IRequestHandler<DiscountGetAllQuery, ICollection<DiscountGetAllQueryResponseDto>>
{
    public async Task<ICollection<DiscountGetAllQueryResponseDto>> Handle(DiscountGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<DiscountGetAllQueryResponseDto>>(
            await discountRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}