using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Notifications.Queries.GetCount;

public class NotificationGetCountQueryHandler(INotificationRepository notificationRepository) : IRequestHandler<NotificationGetCountQuery, int>
{
    public async Task<int> Handle(NotificationGetCountQuery request, CancellationToken cancellationToken)
    {
        return await notificationRepository.CountAsync(cancellationToken: cancellationToken);
    }
}