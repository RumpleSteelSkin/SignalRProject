using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Baskets.Commands.AddWithProductId;

public class BasketAddWithProductIdCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public int ProductId { get; set; }
    public int MenuTableId { get; set; }
}