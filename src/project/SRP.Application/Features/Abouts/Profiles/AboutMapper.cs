using AutoMapper;
using SRP.Application.Features.Abouts.Commands.Add;
using SRP.Application.Features.Abouts.Commands.Update;
using SRP.Application.Features.Abouts.Queries.GetAll;
using SRP.Application.Features.Abouts.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Abouts.Profiles;

public class AboutMapper : Profile
{
    public AboutMapper()
    {
        CreateMap<AboutAddCommand, About>();
        CreateMap<AboutUpdateCommand, About>();
        CreateMap<About, AboutGetAllQueryResponseDto>();
        CreateMap<About, AboutGetByIdQueryResponseDto>();
    }
}