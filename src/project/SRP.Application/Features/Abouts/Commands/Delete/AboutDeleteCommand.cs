using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Abouts.Commands.Delete;

public class AboutDeleteCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public required int Id { get; set; }
}