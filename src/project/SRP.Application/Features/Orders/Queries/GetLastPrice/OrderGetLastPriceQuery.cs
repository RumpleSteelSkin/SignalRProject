using MediatR;

namespace SRP.Application.Features.Orders.Queries.GetLastPrice;

public class OrderGetLastPriceQuery : IRequest<decimal>;