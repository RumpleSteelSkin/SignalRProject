using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.MoneyCases.Commands.Add;

public class MoneyCaseAddCommandHandler(IMoneyCaseRepository moneyCaseRepository, IMapper mapper)
    : IRequestHandler<MoneyCaseAddCommand, string>
{
    public async Task<string> Handle(MoneyCaseAddCommand request, CancellationToken cancellationToken)
    {
        await moneyCaseRepository.AddAsync(mapper.Map<MoneyCase>(request), cancellationToken);
        return $"MoneyCase {request.TotalAmount} has been successfully added.";
    }
}