using FluentValidation;

namespace SRP.Application.Features.Contacts.Commands.Update;

public class ContactUpdateCommandValidator : AbstractValidator<ContactUpdateCommand>
{
    public ContactUpdateCommandValidator()
    {
        RuleFor(x => x.FooterTitle).NotEmpty().WithMessage("Contact title is required");
    }
}