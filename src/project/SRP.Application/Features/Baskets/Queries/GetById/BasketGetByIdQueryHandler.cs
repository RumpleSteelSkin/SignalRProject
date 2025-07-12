using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Baskets.Queries.GetById;

public class BasketGetByIdQueryHandler(IBasketRepository basketRepository, IMapper mapper)
    : IRequestHandler<BasketGetByIdQuery, BasketGetByIdQueryResponseDto>
{
    public async Task<BasketGetByIdQueryResponseDto> Handle(BasketGetByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<BasketGetByIdQueryResponseDto>(await basketRepository.GetByIdAsync(id: request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}