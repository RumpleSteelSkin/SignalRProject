using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Orders.Commands.Update;

public class OrderUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public int Id { get; set; }
    public string? TableNumber { get; set; }
    public string? Description { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
}