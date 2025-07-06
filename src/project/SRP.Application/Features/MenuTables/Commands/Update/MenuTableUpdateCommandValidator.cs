using FluentValidation;

namespace SRP.Application.Features.MenuTables.Commands.Update;

public class MenuTableUpdateCommandValidator : AbstractValidator<MenuTableUpdateCommand>
{
    public MenuTableUpdateCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
    }
}