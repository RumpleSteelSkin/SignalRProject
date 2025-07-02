using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Categories.Queries.GetPassiveCount;

public class CategoryGetPassiveCountQueryHandler(ICategoryRepository categoryRepository)
    : IRequestHandler<CategoryGetPassiveCountQuery, int>
{
    public async Task<int> Handle(CategoryGetPassiveCountQuery request, CancellationToken cancellationToken)
    {
        return await categoryRepository.CountAsync(x => x.Status == false, ignoreQueryFilters: true,
            cancellationToken: cancellationToken);
    }
}