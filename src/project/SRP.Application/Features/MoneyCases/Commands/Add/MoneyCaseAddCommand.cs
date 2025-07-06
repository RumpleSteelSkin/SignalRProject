using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.MoneyCases.Commands.Add;

public class MoneyCaseAddCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public decimal TotalAmount { get; set; }
}