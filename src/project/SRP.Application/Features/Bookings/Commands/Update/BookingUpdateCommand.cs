using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.Bookings.Commands.Update;

public class BookingUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest,IRoleExists
{
    public required int Id { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public string? Description { get; set; }
    public int? PersonCount { get; set; }
    public DateTime Date { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}