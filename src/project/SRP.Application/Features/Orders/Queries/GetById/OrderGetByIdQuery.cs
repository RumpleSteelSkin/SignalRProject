using MediatR;

namespace SRP.Application.Features.Orders.Queries.GetById;

public class OrderGetByIdQuery : IRequest<OrderGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}