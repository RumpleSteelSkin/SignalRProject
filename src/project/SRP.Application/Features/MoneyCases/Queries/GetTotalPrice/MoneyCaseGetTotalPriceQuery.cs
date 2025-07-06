using MediatR;

namespace SRP.Application.Features.MoneyCases.Queries.GetTotalPrice;

public class MoneyCaseGetTotalPriceQuery : IRequest<decimal>;