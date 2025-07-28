using FluentValidation;

namespace SRP.Application.Features.Messages.Commands.Add;

public class MessageAddCommandValidator : AbstractValidator<MessageAddCommand>
{
    public MessageAddCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
    }
}