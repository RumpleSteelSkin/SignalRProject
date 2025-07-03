using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Orders.Commands.Delete;

public class OrderDeleteCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public required int Id { get; set; }
}