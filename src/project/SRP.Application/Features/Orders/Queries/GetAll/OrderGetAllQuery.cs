using MediatR;

namespace SRP.Application.Features.Orders.Queries.GetAll;

public class OrderGetAllQuery : IRequest<ICollection<OrderGetAllQueryResponseDto>>;