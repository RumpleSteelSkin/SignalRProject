using MediatR;

namespace SRP.Application.Features.Categories.Queries.GetById;

public class CategoryGetByIdQuery : IRequest<CategoryGetByIdQueryResponseDto>
{
    public int Id { get; set; }
}