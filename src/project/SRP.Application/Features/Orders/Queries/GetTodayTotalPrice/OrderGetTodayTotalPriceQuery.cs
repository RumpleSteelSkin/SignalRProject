using MediatR;

namespace SRP.Application.Features.Orders.Queries.GetTodayTotalPrice;

public class OrderGetTodayTotalPriceQuery : IRequest<decimal>;