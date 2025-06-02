using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Categories.Queries.GetById;

public class CategoryGetByIdQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    : IRequestHandler<CategoryGetByIdQuery, CategoryGetByIdQueryResponseDto>
{
    public async Task<CategoryGetByIdQueryResponseDto> Handle(CategoryGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<CategoryGetByIdQueryResponseDto>(await categoryRepository.GetByIdAsync(id: request.Id,
            ignoreQueryFilters: true, enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}