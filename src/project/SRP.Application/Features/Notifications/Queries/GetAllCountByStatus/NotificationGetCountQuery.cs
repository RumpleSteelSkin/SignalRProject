using MediatR;

namespace SRP.Application.Features.Notifications.Queries.GetAllCountByStatus;

public class NotificationGetAllCountByStatusQuery : IRequest<int>
{
    public bool Status { get; set; }
}