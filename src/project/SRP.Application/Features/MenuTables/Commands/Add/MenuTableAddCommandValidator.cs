using FluentValidation;

namespace SRP.Application.Features.MenuTables.Commands.Add;

public class MenuTableAddCommandValidator : AbstractValidator<MenuTableAddCommand>
{
    public MenuTableAddCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
    }
}