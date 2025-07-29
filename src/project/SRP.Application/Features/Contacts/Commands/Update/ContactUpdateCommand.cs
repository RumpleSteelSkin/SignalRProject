using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.Contacts.Commands.Update;

public class ContactUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest,IRoleExists
{
    public int Id { get; set; }
    public string? Location { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public string? FooterTitle { get; set; }
    public string? FooterDescription { get; set; }
    public string? OpenDays { get; set; }
    public string? OpenDaysDescription { get; set; }
    public string? OpenHours { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}