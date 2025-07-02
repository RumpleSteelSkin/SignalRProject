using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Categories.Queries.GetActiveCount;

public class CategoryGetActiveCountQueryHandler(ICategoryRepository categoryRepository)
    : IRequestHandler<CategoryGetActiveCountQuery, int>
{
    public async Task<int> Handle(CategoryGetActiveCountQuery request, CancellationToken cancellationToken)
    {
        return await categoryRepository.CountAsync(x => x.Status == true,
            cancellationToken: cancellationToken);
    }
}