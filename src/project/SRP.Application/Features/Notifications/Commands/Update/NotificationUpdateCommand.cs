using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Notifications.Commands.Update;

public class NotificationUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Icon { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}