using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MoneyCases.Commands.Update;

public class MoneyCaseUpdateCommandHandler(IMoneyCaseRepository moneyCaseRepository, IMapper mapper)
    : IRequestHandler<MoneyCaseUpdateCommand, string>
{
    public async Task<string> Handle(MoneyCaseUpdateCommand request, CancellationToken cancellationToken)
    {
        await moneyCaseRepository.UpdateAsync(
            mapper.Map(request,
                await moneyCaseRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("MoneyCase not updated.")), cancellationToken: cancellationToken);
        return $"MoneyCase {request.TotalAmount} is updated.";
    }
}