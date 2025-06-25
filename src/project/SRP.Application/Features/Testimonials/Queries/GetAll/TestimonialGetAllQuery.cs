using MediatR;

namespace SRP.Application.Features.Testimonials.Queries.GetAll;

public class TestimonialGetAllQuery : IRequest<ICollection<TestimonialGetAllQueryResponseDto>>;