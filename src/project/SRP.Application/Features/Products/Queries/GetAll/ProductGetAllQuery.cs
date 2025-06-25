using MediatR;

namespace SRP.Application.Features.Products.Queries.GetAll;

public class ProductGetAllQuery : IRequest<ICollection<ProductGetAllQueryResponseDto>>;