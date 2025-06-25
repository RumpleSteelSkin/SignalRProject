using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Testimonials.Commands.Update;

public class TestimonialUpdateCommandHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
    : IRequestHandler<TestimonialUpdateCommand, string>
{
    public async Task<string> Handle(TestimonialUpdateCommand request, CancellationToken cancellationToken)
    {
        await testimonialRepository.UpdateAsync(
            mapper.Map(request,
                await testimonialRepository.GetByIdAsync(id: request.Id, enableTracking: false, include: false,
                    cancellationToken: cancellationToken) ?? throw new NotFoundException("Testimonial is not found")),
            cancellationToken: cancellationToken);
        return $"Testimonial {request.Name} is updated.";
    }
}