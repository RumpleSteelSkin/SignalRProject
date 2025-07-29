using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.Features.Commands.Add;

public class FeatureAddCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}