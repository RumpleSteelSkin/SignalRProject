using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Notifications.Queries.GetAll;

public class NotificationGetAllQueryHandler(INotificationRepository notificationRepository, IMapper mapper)
    : IRequestHandler<NotificationGetAllQuery, ICollection<NotificationGetAllQueryResponseDto>>
{
    public async Task<ICollection<NotificationGetAllQueryResponseDto>> Handle(NotificationGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<NotificationGetAllQueryResponseDto>>(
            await notificationRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}