using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Notifications.Commands.UpdateStatusById;

public class NotificationUpdateStatusByIdCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public int Id { get; set; }
    public bool Status { get; set; }
}