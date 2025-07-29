using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.SocialMedias.Commands.Add;

public class SocialMediaAddCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? Icon { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}