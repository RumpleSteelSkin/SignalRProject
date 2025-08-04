using AutoMapper;
using SRP.Application.Features.MenuTables.Commands.Add;
using SRP.Application.Features.MenuTables.Commands.Update;
using SRP.Application.Features.MenuTables.Commands.UpdateState;
using SRP.Application.Features.MenuTables.Queries.GetAll;
using SRP.Application.Features.MenuTables.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.MenuTables.Profiles;

public class MenuTableMapper : Profile
{
    public MenuTableMapper()
    {
        CreateMap<MenuTableAddCommand, MenuTable>();
        CreateMap<MenuTableUpdateCommand, MenuTable>();
        CreateMap<MenuTableUpdateStateCommand, MenuTable>();
        CreateMap<MenuTable, MenuTableGetAllQueryResponseDto>();
        CreateMap<MenuTable, MenuTableGetByIdQueryResponseDto>();
    }
}