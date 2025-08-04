using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.MenuTables.Commands.UpdateState;

public class MenuTableUpdateStateCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public int Id { get; set; }
    public bool Status { get; set; }
}