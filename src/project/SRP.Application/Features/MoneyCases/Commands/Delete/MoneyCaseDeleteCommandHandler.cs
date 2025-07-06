using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MoneyCases.Commands.Delete;

public class MoneyCaseDeleteCommandHandler(IMoneyCaseRepository moneyCaseRepository) : IRequestHandler<MoneyCaseDeleteCommand, string>
{
    public async Task<string> Handle(MoneyCaseDeleteCommand request, CancellationToken cancellationToken)
    {
        await moneyCaseRepository.HardDeleteAsync(
            await moneyCaseRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, include: false,
                enableTracking: false,
                cancellationToken: cancellationToken) ?? throw new NotFoundException("MoneyCase is not found"),
            cancellationToken: cancellationToken);
        return "MoneyCase is deleted";
    }
}