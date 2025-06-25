using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Commands.Update;

public class ProductUpdateCommandHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<ProductUpdateCommand, string>
{
    public async Task<string> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
    {
        await productRepository.UpdateAsync(
            mapper.Map(request,
                await productRepository.GetByIdAsync(id: request.Id, enableTracking: false, include: false,
                    cancellationToken: cancellationToken) ?? throw new NotFoundException("Product is not found")),
            cancellationToken: cancellationToken);
        return $"Product {request.Name} is updated.";
    }
}