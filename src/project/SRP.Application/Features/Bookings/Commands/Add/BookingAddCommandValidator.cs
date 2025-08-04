using FluentValidation;

namespace SRP.Application.Features.Bookings.Commands.Add;

public class BookingAddCommandValidator : AbstractValidator<BookingAddCommand>
{
    public BookingAddCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Booking name is required.")
            .MinimumLength(3).WithMessage("Booking name must be between 3 and 50 characters long.")
            .MaximumLength(50).WithMessage("Booking name must be between 3 and 50 characters long.");
        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Phone is required.");
        RuleFor(x => x.Mail)
            .NotEmpty().WithMessage("Mail is required.")
            .EmailAddress().WithMessage("Please enter a valid email address");
        RuleFor(x => x.PersonCount)
            .NotEmpty().WithMessage("Person Count is required.");
        RuleFor(x => x.Date)
            .NotEmpty().WithMessage("Date is required.");
    }
}