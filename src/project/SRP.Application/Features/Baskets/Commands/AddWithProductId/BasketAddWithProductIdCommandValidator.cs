using FluentValidation;

namespace SRP.Application.Features.Baskets.Commands.AddWithProductId;

public class BasketAddWithProductIdCommandValidator : AbstractValidator<BasketAddWithProductIdCommand>
{
    public BasketAddWithProductIdCommandValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId is required.");
    }
}