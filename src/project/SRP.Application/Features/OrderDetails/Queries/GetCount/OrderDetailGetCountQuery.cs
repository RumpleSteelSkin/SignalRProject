using MediatR;

namespace SRP.Application.Features.OrderDetails.Queries.GetCount;

public class OrderDetailGetCountQuery : IRequest<int>;