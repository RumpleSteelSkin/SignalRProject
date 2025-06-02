using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Categories.Commands.Add;

public class CategoryAddCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
    : IRequestHandler<CategoryAddCommand, string>
{
    public async Task<string> Handle(CategoryAddCommand request, CancellationToken cancellationToken)
    {
        await categoryRepository.AddAsync(mapper.Map<Category>(request), cancellationToken: cancellationToken);
        return $"Category {request.Name} is added.";
    }
}