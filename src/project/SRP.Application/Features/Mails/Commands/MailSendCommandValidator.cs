using FluentValidation;

namespace SRP.Application.Features.Mails.Commands;

public class MailSendCommandValidator : AbstractValidator<MailSendCommand>
{
    public MailSendCommandValidator()
    {
        RuleFor(x => x.FromName)
            .NotNull().NotEmpty().WithMessage("From Email field cannot be empty.");

        RuleFor(x => x.ToName)
            .NotNull().NotEmpty().WithMessage("To Email field cannot be empty.");

        RuleFor(x => x.FromMail)
            .NotNull().NotEmpty().WithMessage("From Email field cannot be empty.")
            .EmailAddress().WithMessage("Please enter a valid from email address.");

        RuleFor(x => x.ToMail)
            .NotNull().NotEmpty().WithMessage("To Email field cannot be empty.")
            .EmailAddress().WithMessage("Please enter a valid to email address.");

        RuleFor(x => x.FromKey)
            .NotNull().NotEmpty().WithMessage("From Key field cannot be empty.");

        RuleFor(x => x.Subject)
            .NotNull().NotEmpty().WithMessage("Subject field cannot be empty.");

        RuleFor(x => x.Body)
            .NotNull().NotEmpty().WithMessage("Body field cannot be empty.");
    }
}