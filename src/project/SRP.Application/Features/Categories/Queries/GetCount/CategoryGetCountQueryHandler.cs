using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Categories.Queries.GetCount;

public class CategoryGetCountQueryHandler(ICategoryRepository categoryRepository)
    : IRequestHandler<CategoryGetCountQuery, int>
{
    public async Task<int> Handle(CategoryGetCountQuery request, CancellationToken cancellationToken)
    {
        return await categoryRepository.CountAsync(cancellationToken: cancellationToken);
    }
}