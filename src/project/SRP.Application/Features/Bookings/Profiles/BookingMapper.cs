using AutoMapper;
using SRP.Application.Features.Bookings.Commands.Add;
using SRP.Application.Features.Bookings.Commands.Update;
using SRP.Application.Features.Bookings.Queries.GetAll;
using SRP.Application.Features.Bookings.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Bookings.Profiles;

public class BookingMapper : Profile
{
    public BookingMapper()
    {
        CreateMap<BookingAddCommand, Booking>();
        CreateMap<BookingUpdateCommand, Booking>();
        CreateMap<Booking, BookingGetAllQueryResponseDto>();
        CreateMap<Booking, BookingGetByIdQueryResponseDto>();
    }
}