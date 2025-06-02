using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Discounts.Commands.Add;

public class DiscountAddCommandHandler(IDiscountRepository discountRepository, IMapper mapper)
    : IRequestHandler<DiscountAddCommand, string>
{
    public async Task<string> Handle(DiscountAddCommand request, CancellationToken cancellationToken)
    {
        await discountRepository.AddAsync(mapper.Map<Discount>(request), cancellationToken: cancellationToken);
        return $"Discount {request.Title} is added.";
    }
}