using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.Abouts.Commands.Delete;

public class AboutDeleteCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public required int Id { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}