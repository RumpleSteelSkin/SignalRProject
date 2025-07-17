using MediatR;

namespace SRP.Application.Features.Notifications.Commands.UpdateStatusById;

public class NotificationUpdateStatusByIdCommand : IRequest<string>
{
    public int Id { get; set; }
    public bool Status { get; set; }
}