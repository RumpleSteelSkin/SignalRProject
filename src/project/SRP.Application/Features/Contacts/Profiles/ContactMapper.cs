using AutoMapper;
using SRP.Application.Features.Contacts.Commands.Add;
using SRP.Application.Features.Contacts.Commands.Update;
using SRP.Application.Features.Contacts.Queries.GetAll;
using SRP.Application.Features.Contacts.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Contacts.Profiles;

public class ContactMapper : Profile
{
    public ContactMapper()
    {
        CreateMap<ContactAddCommand, Contact>();
        CreateMap<ContactUpdateCommand, Contact>();
        CreateMap<Contact, ContactGetAllQueryResponseDto>();
        CreateMap<Contact, ContactGetByIdQueryResponseDto>();
    }
}