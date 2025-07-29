using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.Discounts.Commands.Add;

public class DiscountAddCommand : IRequest<string>, ITransactional, ILoggableRequest,IRoleExists
{
    public string? Title { get; set; }
    public string? Amount { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}