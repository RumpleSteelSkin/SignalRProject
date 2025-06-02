using MediatR;

namespace SRP.Application.Features.Categories.Queries.GetAll;

public class CategoryGetAllQuery : IRequest<ICollection<CategoryGetAllQueryResponseDto>>;