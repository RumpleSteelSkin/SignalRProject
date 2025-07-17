using FluentValidation;

namespace SRP.Application.Features.Notifications.Commands.Update;

public class NotificationUpdateCommandValidator : AbstractValidator<NotificationUpdateCommand>
{
    public NotificationUpdateCommandValidator()
    {
        RuleFor(x => x.Type).NotEmpty().WithMessage("Type is required.");
    }
}