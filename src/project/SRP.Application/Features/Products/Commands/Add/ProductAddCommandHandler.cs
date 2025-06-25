using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Products.Commands.Add;

public class ProductAddCommandHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<ProductAddCommand, string>
{
    public async Task<string> Handle(ProductAddCommand request, CancellationToken cancellationToken)
    {
        await productRepository.AddAsync(mapper.Map<Product>(request), cancellationToken: cancellationToken);
        return $"Product {request.Name} is added.";
    }
}