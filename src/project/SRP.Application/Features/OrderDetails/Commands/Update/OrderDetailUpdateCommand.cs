using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.OrderDetails.Commands.Update;

public class OrderDetailUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public int Id { get; set; }
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public int Count { get; set; }
    public int OrderID { get; set; }
}