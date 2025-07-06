using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.MenuTables.Commands.Delete;

public class MenuTableDeleteCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public required int Id { get; set; }
}