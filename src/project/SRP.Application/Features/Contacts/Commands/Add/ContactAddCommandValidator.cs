using FluentValidation;

namespace SRP.Application.Features.Contacts.Commands.Add;

public class ContactAddCommandValidator : AbstractValidator<ContactAddCommand>
{
    public ContactAddCommandValidator()
    {
        RuleFor(x => x.FooterTitle).NotEmpty().WithMessage("Contact title is required");
    }
}