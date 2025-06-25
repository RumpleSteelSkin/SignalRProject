using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Testimonials.Queries.GetById;

public class TestimonialGetByIdQueryHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
    : IRequestHandler<TestimonialGetByIdQuery, TestimonialGetByIdQueryResponseDto>
{
    public async Task<TestimonialGetByIdQueryResponseDto> Handle(TestimonialGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<TestimonialGetByIdQueryResponseDto>(await testimonialRepository.GetByIdAsync(id: request.Id,
            ignoreQueryFilters: true, enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}