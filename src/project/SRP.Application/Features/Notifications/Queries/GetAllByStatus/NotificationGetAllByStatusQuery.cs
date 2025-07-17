using MediatR;

namespace SRP.Application.Features.Notifications.Queries.GetAllByStatus;

public class NotificationGetAllByStatusQuery : IRequest<ICollection<NotificationGetAllByStatusQueryResponseDto>>
{
    public bool Status { get; set; }
}