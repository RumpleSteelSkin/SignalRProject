using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.MenuTables.Commands.Add;

public class MenuTableAddCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public string? Name { get; set; }
}