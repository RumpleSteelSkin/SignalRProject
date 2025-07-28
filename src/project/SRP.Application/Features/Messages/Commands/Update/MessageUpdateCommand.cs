using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Messages.Commands.Update;

public class MessageUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public required int Id { get; set; }
    public string? Name { get; set; }
    public string? Mail { get; set; }
    public string? Phone { get; set; }
    public string? Subject { get; set; }
    public string? MessageContent { get; set; }
}