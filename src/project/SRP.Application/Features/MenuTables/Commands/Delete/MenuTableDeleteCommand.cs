using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.MenuTables.Commands.Delete;

public class MenuTableDeleteCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public required int Id { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}