using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Notifications.Commands.Add;

public class NotificationAddCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public string? Type { get; set; }
    public string? Icon { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; } = false;
}