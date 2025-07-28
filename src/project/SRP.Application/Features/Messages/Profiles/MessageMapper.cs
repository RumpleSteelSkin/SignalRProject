using AutoMapper;
using SRP.Application.Features.Messages.Commands.Add;
using SRP.Application.Features.Messages.Commands.Update;
using SRP.Application.Features.Messages.Queries.GetAll;
using SRP.Application.Features.Messages.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Messages.Profiles;

public class MessageMapper : Profile
{
    public MessageMapper()
    {
        CreateMap<MessageAddCommand, Message>();
        CreateMap<MessageUpdateCommand, Message>();
        CreateMap<Message, MessageGetAllQueryResponseDto>();
        CreateMap<Message, MessageGetByIdQueryResponseDto>();
    }
}