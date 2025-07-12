using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Baskets.Commands.Add;

public class BasketAddCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public decimal Price { get; set; }
    public decimal Count { get; set; }
    public decimal TotalPrice { get; set; }
    public int ProductID { get; set; }
    public int MenuTableID { get; set; }
}