using AutoMapper;
using SRP.Application.Features.Notifications.Commands.Add;
using SRP.Application.Features.Notifications.Commands.Update;
using SRP.Application.Features.Notifications.Queries.GetAll;
using SRP.Application.Features.Notifications.Queries.GetAllByStatus;
using SRP.Application.Features.Notifications.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Notifications.Profiles;

public class NotificationMapper : Profile
{
    public NotificationMapper()
    {
        CreateMap<NotificationAddCommand, Notification>();
        CreateMap<NotificationUpdateCommand, Notification>();
        CreateMap<Notification, NotificationGetAllQueryResponseDto>();
        CreateMap<Notification, NotificationGetByIdQueryResponseDto>();
        CreateMap<Notification, NotificationGetAllByStatusQueryResponseDto>();
    }
}