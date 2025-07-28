using FluentValidation;

namespace SRP.Application.Features.Authentication.Commands.Login;

public class LoginValidator : AbstractValidator<LoginCommand>
{
    public LoginValidator()
    {
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password field cannot be empty.");
        RuleFor(x => x.UserNameOrEmail).NotEmpty().WithMessage("Username Or Email field cannot be empty.");
    }
}