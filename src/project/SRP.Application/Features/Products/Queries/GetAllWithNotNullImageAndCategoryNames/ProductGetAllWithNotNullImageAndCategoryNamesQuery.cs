using MediatR;

namespace SRP.Application.Features.Products.Queries.GetAllWithNotNullImageAndCategoryNames;

public class
    ProductGetAllWithNotNullImageAndCategoryNamesQuery : IRequest<
    ICollection<ProductGetAllWithNotNullImageAndCategoryNamesQueryResponseDto>>
{
    public string[]? CategoryNames { get; set; }
}