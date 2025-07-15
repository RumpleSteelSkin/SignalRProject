using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Baskets.Queries.GetByMenuTableNumber;

public class BasketGetByMenuTableNumberQueryHandler(IBasketRepository basketRepository, IMapper mapper)
    : IRequestHandler<BasketGetByMenuTableNumberQuery, ICollection<BasketGetByMenuTableNumberQueryResponseDto>>
{
    public async Task<ICollection<BasketGetByMenuTableNumberQueryResponseDto>> Handle(
        BasketGetByMenuTableNumberQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<BasketGetByMenuTableNumberQueryResponseDto>>(await basketRepository.GetAllAsync(
            filter: x => x.MenuTableID == request.MenuTableID, include: true, ignoreQueryFilters: false,
            cancellationToken: cancellationToken));
    }
}