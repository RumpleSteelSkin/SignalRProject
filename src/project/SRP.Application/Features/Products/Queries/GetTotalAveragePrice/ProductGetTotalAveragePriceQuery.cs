using MediatR;

namespace SRP.Application.Features.Products.Queries.GetTotalAveragePrice;

public class ProductGetTotalAveragePriceQuery : IRequest<decimal>;