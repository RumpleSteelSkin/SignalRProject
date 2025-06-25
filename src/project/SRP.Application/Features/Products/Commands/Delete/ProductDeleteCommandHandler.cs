using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Commands.Delete;

public class ProductDeleteCommandHandler(IProductRepository productRepository)
    : IRequestHandler<ProductDeleteCommand, string>
{
    public async Task<string> Handle(ProductDeleteCommand request, CancellationToken cancellationToken)
    {
        await productRepository.HardDeleteAsync(
            await productRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, enableTracking: false,
                include: false, cancellationToken: cancellationToken) ??
            throw new NotFoundException("Product not found."), cancellationToken: cancellationToken);
        return "Product is deleted.";
    }
}