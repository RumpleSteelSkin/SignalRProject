using AutoMapper;
using SRP.Application.Features.Testimonials.Commands.Add;
using SRP.Application.Features.Testimonials.Commands.Update;
using SRP.Application.Features.Testimonials.Queries.GetAll;
using SRP.Application.Features.Testimonials.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Testimonials.Profiles;

public class TestimonialMapper : Profile
{
    public TestimonialMapper()
    {
        CreateMap<TestimonialAddCommand, Testimonial>();
        CreateMap<TestimonialUpdateCommand, Testimonial>();
        CreateMap<Testimonial, TestimonialGetAllQueryResponseDto>();
        CreateMap<Testimonial, TestimonialGetByIdQueryResponseDto>();
    }
}