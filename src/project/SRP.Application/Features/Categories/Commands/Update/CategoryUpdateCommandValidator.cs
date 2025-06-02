using FluentValidation;

namespace SRP.Application.Features.Categories.Commands.Update;

public class CategoryUpdateCommandValidator : AbstractValidator<CategoryUpdateCommand>
{
    public CategoryUpdateCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Category name is required");
    }
}