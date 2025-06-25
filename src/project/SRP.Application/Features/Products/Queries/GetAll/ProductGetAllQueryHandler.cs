using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetAll;

public class ProductGetAllQueryHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<ProductGetAllQuery, ICollection<ProductGetAllQueryResponseDto>>
{
    public async Task<ICollection<ProductGetAllQueryResponseDto>> Handle(ProductGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<ProductGetAllQueryResponseDto>>(
            await productRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}