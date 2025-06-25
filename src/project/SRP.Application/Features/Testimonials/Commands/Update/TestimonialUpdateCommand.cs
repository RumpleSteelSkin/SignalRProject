using MediatR;

namespace SRP.Application.Features.Testimonials.Commands.Update;

public class TestimonialUpdateCommand : IRequest<string>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Comment { get; set; }
    public string? ImageUrl { get; set; }
}