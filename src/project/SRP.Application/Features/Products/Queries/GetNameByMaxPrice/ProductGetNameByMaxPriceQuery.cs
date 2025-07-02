using MediatR;

namespace SRP.Application.Features.Products.Queries.GetNameByMaxPrice;

public class ProductGetNameByMaxPriceQuery : IRequest<string>;