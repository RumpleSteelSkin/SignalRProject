using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Notifications.Queries.GetAllCountByStatus;

public class NotificationGetAllCountByStatusQueryHandler(INotificationRepository notificationRepository)
    : IRequestHandler<NotificationGetAllCountByStatusQuery, int>
{
    public async Task<int> Handle(NotificationGetAllCountByStatusQuery request, CancellationToken cancellationToken)
    {
        return await notificationRepository.CountAsync(filter: x => x.Status == request.Status,
            cancellationToken: cancellationToken);
    }
}