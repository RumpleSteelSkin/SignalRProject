using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.MoneyCases.Commands.Update;

public class MoneyCaseUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public int Id { get; set; }
    public decimal TotalAmount { get; set; }
}