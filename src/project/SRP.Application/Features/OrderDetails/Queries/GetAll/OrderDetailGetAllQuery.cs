using MediatR;

namespace SRP.Application.Features.OrderDetails.Queries.GetAll;

public class OrderDetailGetAllQuery : IRequest<ICollection<OrderDetailGetAllQueryResponseDto>>;