using AutoMapper;
using SRP.Application.Features.OrderDetails.Commands.Add;
using SRP.Application.Features.OrderDetails.Commands.Update;
using SRP.Application.Features.OrderDetails.Queries.GetAll;
using SRP.Application.Features.OrderDetails.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.OrderDetails.Profiles;

public class OrderDetailMapper : Profile
{
    public OrderDetailMapper()
    {
        CreateMap<OrderDetailAddCommand, OrderDetail>();
        CreateMap<OrderDetailUpdateCommand, OrderDetail>();
        CreateMap<OrderDetail, OrderDetailGetAllQueryResponseDto>();
        CreateMap<OrderDetail, OrderDetailGetByIdQueryResponseDto>();
    }
}