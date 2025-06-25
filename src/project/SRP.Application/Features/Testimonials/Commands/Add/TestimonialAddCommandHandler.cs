using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Testimonials.Commands.Add;

public class TestimonialAddCommandHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
    : IRequestHandler<TestimonialAddCommand, string>
{
    public async Task<string> Handle(TestimonialAddCommand request, CancellationToken cancellationToken)
    {
        await testimonialRepository.AddAsync(mapper.Map<Testimonial>(request), cancellationToken: cancellationToken);
        return $"Testimonial {request.Title} is added.";
    }
}