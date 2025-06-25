using MediatR;

namespace SRP.Application.Features.Testimonials.Commands.Delete;

public class TestimonialDeleteCommand : IRequest<string>
{
    public int Id { get; set; }
}