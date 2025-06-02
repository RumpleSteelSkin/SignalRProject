using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Categories.Commands.Delete;

public class CategoryDeleteCommandHandler(ICategoryRepository categoryRepository):IRequestHandler<CategoryDeleteCommand,string>
{
    public async Task<string> Handle(CategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        await categoryRepository.HardDeleteAsync(
            await categoryRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, enableTracking: false,
                include: false, cancellationToken: cancellationToken) ??
            throw new NotFoundException("Category not found."), cancellationToken: cancellationToken);
        return "Category is deleted.";
    }
}