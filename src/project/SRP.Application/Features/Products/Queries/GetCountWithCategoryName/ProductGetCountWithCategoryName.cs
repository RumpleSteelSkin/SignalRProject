using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;

namespace SRP.Application.Features.Products.Queries.GetCountWithCategoryName;

public class ProductGetCountWithCategoryName : IRequest<int>
{
    public string? CategoryName { get; set; }
}