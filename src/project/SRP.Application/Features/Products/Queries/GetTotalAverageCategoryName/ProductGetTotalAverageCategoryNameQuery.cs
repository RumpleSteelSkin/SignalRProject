using MediatR;

namespace SRP.Application.Features.Products.Queries.GetTotalAverageCategoryName;

public class ProductGetTotalAverageCategoryNameQuery : IRequest<decimal>
{
    public string? CategoryName { get; set; }
}