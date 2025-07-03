using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.OrderDetails.Commands.Add;

public class OrderDetailAddCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public int Count { get; set; }
    public int OrderID { get; set; }
}