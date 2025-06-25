using FluentValidation;

namespace SRP.Application.Features.Testimonials.Commands.Update;

public class TestimonialUpdateCommandValidator : AbstractValidator<TestimonialUpdateCommand>
{
    public TestimonialUpdateCommandValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Name is required");
    }
}