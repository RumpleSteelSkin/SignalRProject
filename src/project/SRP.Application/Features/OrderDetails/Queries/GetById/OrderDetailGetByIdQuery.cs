using MediatR;

namespace SRP.Application.Features.OrderDetails.Queries.GetById;

public class OrderDetailGetByIdQuery : IRequest<OrderDetailGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}