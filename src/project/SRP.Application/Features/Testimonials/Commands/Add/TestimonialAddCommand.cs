using MediatR;

namespace SRP.Application.Features.Testimonials.Commands.Add;

public class TestimonialAddCommand : IRequest<string>
{
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Comment { get; set; }
    public string? ImageUrl { get; set; }
}