using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Categories.Commands.Update;

public class CategoryUpdateCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
    : IRequestHandler<CategoryUpdateCommand, string>
{
    public async Task<string> Handle(CategoryUpdateCommand request, CancellationToken cancellationToken)
    {
        await categoryRepository.UpdateAsync(
            mapper.Map(request,
                await categoryRepository.GetByIdAsync(id: request.Id, enableTracking: false, include: false,
                    cancellationToken: cancellationToken) ?? throw new NotFoundException("Category is not found")),
            cancellationToken: cancellationToken);
        return $"Category {request.Name} is updated.";
    }
}