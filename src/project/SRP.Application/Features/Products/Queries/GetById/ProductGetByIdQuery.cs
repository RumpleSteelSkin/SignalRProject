using MediatR;

namespace SRP.Application.Features.Products.Queries.GetById;

public class ProductGetByIdQuery : IRequest<ProductGetByIdQueryResponseDto>
{
    public int Id { get; set; }
}