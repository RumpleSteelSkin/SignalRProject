using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Discounts.Queries.GetAllByStatus;

public class DiscountGetAllByStatusQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
    : IRequestHandler<DiscountGetAllByStatusQuery, ICollection<DiscountGetAllByStatusQueryResponseDto>>
{
    public async Task<ICollection<DiscountGetAllByStatusQueryResponseDto>> Handle(DiscountGetAllByStatusQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<DiscountGetAllByStatusQueryResponseDto>>(
            await discountRepository.GetAllAsync(filter: x => x.Status == request.Status, enableTracking: false,
                include: false,
                cancellationToken: cancellationToken));
    }
}