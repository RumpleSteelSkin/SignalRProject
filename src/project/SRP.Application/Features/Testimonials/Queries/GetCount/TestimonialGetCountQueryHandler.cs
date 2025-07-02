using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Testimonials.Queries.GetCount;

public class TestimonialGetCountQueryHandler(ITestimonialRepository testimonialRepository)
    : IRequestHandler<TestimonialGetCountQuery, int>
{
    public async Task<int> Handle(TestimonialGetCountQuery request, CancellationToken cancellationToken)
    {
        return await testimonialRepository.CountAsync(cancellationToken: cancellationToken);
    }
}