using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Testimonials.Queries.GetAll;

public class TestimonialGetAllQueryHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
    : IRequestHandler<TestimonialGetAllQuery, ICollection<TestimonialGetAllQueryResponseDto>>
{
    public async Task<ICollection<TestimonialGetAllQueryResponseDto>> Handle(TestimonialGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<TestimonialGetAllQueryResponseDto>>(
            await testimonialRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}