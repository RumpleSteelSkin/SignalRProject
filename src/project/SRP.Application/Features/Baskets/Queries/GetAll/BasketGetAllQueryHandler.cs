using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Baskets.Queries.GetAll;

public class BasketGetAllQueryHandler(IBasketRepository basketRepository, IMapper mapper)
    : IRequestHandler<BasketGetAllQuery, ICollection<BasketGetAllQueryResponseDto>>
{
    public async Task<ICollection<BasketGetAllQueryResponseDto>> Handle(BasketGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<BasketGetAllQueryResponseDto>>(
            await basketRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}