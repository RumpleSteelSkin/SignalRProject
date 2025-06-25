using AutoMapper;
using SRP.Application.Features.SocialMedias.Commands.Add;
using SRP.Application.Features.SocialMedias.Commands.Update;
using SRP.Application.Features.SocialMedias.Queries.GetAll;
using SRP.Application.Features.SocialMedias.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.SocialMedias.Profiles;

public class SocialMediaMapper : Profile
{
    public SocialMediaMapper()
    {
        CreateMap<SocialMediaAddCommand, SocialMedia>();
        CreateMap<SocialMediaUpdateCommand, SocialMedia>();
        CreateMap<SocialMedia, SocialMediaGetAllQueryResponseDto>();
        CreateMap<SocialMedia, SocialMediaGetByIdQueryResponseDto>();
    }
}