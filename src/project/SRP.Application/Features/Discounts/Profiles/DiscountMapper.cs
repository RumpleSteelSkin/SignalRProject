using AutoMapper;
using SRP.Application.Features.Discounts.Commands.Add;
using SRP.Application.Features.Discounts.Commands.Update;
using SRP.Application.Features.Discounts.Queries.GetAll;
using SRP.Application.Features.Discounts.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Discounts.Profiles;

public class DiscountMapper : Profile
{
    public DiscountMapper()
    {
        CreateMap<DiscountAddCommand, Discount>();
        CreateMap<DiscountUpdateCommand, Discount>();
        CreateMap<Discount, DiscountGetAllQueryResponseDto>();
        CreateMap<Discount, DiscountGetByIdQueryResponseDto>();
    }
}