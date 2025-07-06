using AutoMapper;
using SRP.Application.Features.MoneyCases.Commands.Add;
using SRP.Application.Features.MoneyCases.Commands.Update;
using SRP.Application.Features.MoneyCases.Queries.GetAll;
using SRP.Application.Features.MoneyCases.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.MoneyCases.Profiles;

public class MoneyCaseMapper : Profile
{
    public MoneyCaseMapper()
    {
        CreateMap<MoneyCaseAddCommand, MoneyCase>();
        CreateMap<MoneyCaseUpdateCommand, MoneyCase>();
        CreateMap<MoneyCase, MoneyCaseGetAllQueryResponseDto>();
        CreateMap<MoneyCase, MoneyCaseGetByIdQueryResponseDto>();
    }
}