using AutoMapper;
using SRP.Application.Features.Orders.Commands.Add;
using SRP.Application.Features.Orders.Commands.Update;
using SRP.Application.Features.Orders.Queries.GetAll;
using SRP.Application.Features.Orders.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Orders.Profiles;

public class OrderMapper : Profile
{
    public OrderMapper()
    {
        CreateMap<OrderAddCommand, Order>();
        CreateMap<OrderUpdateCommand, Order>();
        CreateMap<Order, OrderGetAllQueryResponseDto>();
        CreateMap<Order, OrderGetByIdQueryResponseDto>();
    }
}