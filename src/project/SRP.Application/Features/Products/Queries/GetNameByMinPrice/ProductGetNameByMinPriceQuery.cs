using MediatR;

namespace SRP.Application.Features.Products.Queries.GetNameByMinPrice;

public class ProductGetNameByMinPriceQuery : IRequest<string>;