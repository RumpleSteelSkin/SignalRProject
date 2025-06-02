using FluentValidation;

namespace SRP.Application.Features.Categories.Commands.Add;

public class CategoryAddCommandValidator : AbstractValidator<CategoryAddCommand>
{
    public CategoryAddCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Category name is required");
    }
}