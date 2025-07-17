using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Notifications.Queries.GetAllByStatus;

public class NotificationGetAllByStatusQueryHandler(INotificationRepository notificationRepository, IMapper mapper)
    : IRequestHandler<NotificationGetAllByStatusQuery, ICollection<NotificationGetAllByStatusQueryResponseDto>>
{
    public async Task<ICollection<NotificationGetAllByStatusQueryResponseDto>> Handle(
        NotificationGetAllByStatusQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<NotificationGetAllByStatusQueryResponseDto>>(
            await notificationRepository.GetAllAsync(filter: x => x.Status == request.Status, enableTracking: false,
                include: false,
                cancellationToken: cancellationToken));
    }
}