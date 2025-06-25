using FluentValidation;

namespace SRP.Application.Features.Testimonials.Commands.Add;

public class TestimonialAddCommandValidator : AbstractValidator<TestimonialAddCommand>
{
    public TestimonialAddCommandValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Name is required");
    }
}