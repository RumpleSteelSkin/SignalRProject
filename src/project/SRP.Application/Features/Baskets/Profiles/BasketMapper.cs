using AutoMapper;
using SRP.Application.Features.Baskets.Commands.Add;
using SRP.Application.Features.Baskets.Commands.Update;
using SRP.Application.Features.Baskets.Queries.GetAll;
using SRP.Application.Features.Baskets.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Baskets.Profiles;

public class BasketMapper : Profile
{
    public BasketMapper()
    {
        CreateMap<BasketAddCommand, Basket>();
        CreateMap<BasketUpdateCommand, Basket>();
        CreateMap<Basket, BasketGetAllQueryResponseDto>();
        CreateMap<Basket, BasketGetByIdQueryResponseDto>();
    }
}