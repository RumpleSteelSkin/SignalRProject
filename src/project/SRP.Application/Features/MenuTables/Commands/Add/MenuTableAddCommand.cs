using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.MenuTables.Commands.Add;

public class MenuTableAddCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public string? Name { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}