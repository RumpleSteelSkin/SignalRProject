using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Baskets.Commands.Add;

public class BasketAddCommandHandler(IBasketRepository basketRepository, IMapper mapper)
    : IRequestHandler<BasketAddCommand, string>
{
    public async Task<string> Handle(BasketAddCommand request, CancellationToken cancellationToken)
    {
        await basketRepository.AddAsync(mapper.Map<Basket>(request), cancellationToken);
        return $"Basket {request.TotalPrice} has been successfully added.";
    }
}