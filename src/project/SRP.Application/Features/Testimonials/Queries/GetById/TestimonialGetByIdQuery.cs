using MediatR;

namespace SRP.Application.Features.Testimonials.Queries.GetById;

public class TestimonialGetByIdQuery : IRequest<TestimonialGetByIdQueryResponseDto>
{
    public int Id { get; set; }
}