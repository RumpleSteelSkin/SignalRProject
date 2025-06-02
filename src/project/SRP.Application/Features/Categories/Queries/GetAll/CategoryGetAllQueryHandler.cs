using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Categories.Queries.GetAll;

public class CategoryGetAllQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    : IRequestHandler<CategoryGetAllQuery, ICollection<CategoryGetAllQueryResponseDto>>
{
    public async Task<ICollection<CategoryGetAllQueryResponseDto>> Handle(CategoryGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<CategoryGetAllQueryResponseDto>>(
            await categoryRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}