using AutoMapper;
using SRP.Application.Features.Features.Commands.Add;
using SRP.Application.Features.Features.Commands.Update;
using SRP.Application.Features.Features.Queries.GetAll;
using SRP.Application.Features.Features.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Features.Profiles;

public class FeatureMapper : Profile
{
    public FeatureMapper()
    {
        CreateMap<FeatureAddCommand, Feature>();
        CreateMap<FeatureUpdateCommand, Feature>();
        CreateMap<Feature, FeatureGetAllQueryResponseDto>();
        CreateMap<Feature, FeatureGetByIdQueryResponseDto>();
    }
}