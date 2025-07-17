using MediatR;

namespace SRP.Application.Features.Notifications.Queries.GetAll;

public class NotificationGetAllQuery : IRequest<ICollection<NotificationGetAllQueryResponseDto>>;