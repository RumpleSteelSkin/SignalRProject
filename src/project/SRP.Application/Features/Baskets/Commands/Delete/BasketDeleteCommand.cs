using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Baskets.Commands.Delete;

public class BasketDeleteCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public required int Id { get; set; }
}