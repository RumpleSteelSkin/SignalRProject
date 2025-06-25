using FluentValidation;

namespace SRP.Application.Features.Products.Commands.Add;

public class ProductAddCommandValidator : AbstractValidator<ProductAddCommand>
{
    public ProductAddCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
    }
}