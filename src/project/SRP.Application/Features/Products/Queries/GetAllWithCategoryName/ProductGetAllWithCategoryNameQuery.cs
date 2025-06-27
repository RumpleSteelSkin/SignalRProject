using MediatR;

namespace SRP.Application.Features.Products.Queries.GetAllWithCategoryName;

public class ProductGetAllWithCategoryNameQuery : IRequest<ICollection<ProductGetAllWithCategoryNameQueryResponseDto>>;