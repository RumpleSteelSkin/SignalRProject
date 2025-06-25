using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetById;

public class ProductGetByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<ProductGetByIdQuery, ProductGetByIdQueryResponseDto>
{
    public async Task<ProductGetByIdQueryResponseDto> Handle(ProductGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ProductGetByIdQueryResponseDto>(await productRepository.GetByIdAsync(id: request.Id,
            ignoreQueryFilters: true, enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}