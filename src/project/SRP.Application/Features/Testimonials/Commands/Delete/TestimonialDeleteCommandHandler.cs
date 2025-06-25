using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Testimonials.Commands.Delete;

public class TestimonialDeleteCommandHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
    : IRequestHandler<TestimonialDeleteCommand, string>
{
    public async Task<string> Handle(TestimonialDeleteCommand request, CancellationToken cancellationToken)
    {
        await testimonialRepository.HardDeleteAsync(
            await testimonialRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, enableTracking: false,
                include: false, cancellationToken: cancellationToken) ??
            throw new NotFoundException("Testimonial not found."), cancellationToken: cancellationToken);
        return "Testimonial is deleted.";
    }
}