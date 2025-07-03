using MediatR;

namespace SRP.Application.Features.Orders.Queries.GetCount;

public class OrderGetCountQuery : IRequest<int>;