using AutoMapper;
using SRP.Application.Features.Authentication.Commands.UpdateUser;
using SRP.Application.Features.Authentication.Queries.GetAllUsers;
using SRP.Application.Features.Authentication.Queries.GetUserById;
using SRP.Application.Features.Authentication.Queries.GetUsersByRoleId;
using SRP.Domain.Models;

namespace SRP.Application.Features.Authentication.Profiles;

public class AuthenticationMapper : Profile
{
    public AuthenticationMapper()
    {
        CreateMap<AppUser, GetAllUsersQueryResponseDto>()
            .ForMember(x => x.FullName, opt => opt.MapFrom(x => $"{x.Name} {x.Surname}"));

        CreateMap<AppUser, GetUserByIdQueryResponseDto>()
            .ForMember(x => x.FullName, opt => opt.MapFrom(x => $"{x.Name} {x.Surname}"));

        CreateMap<AppUser, GetUsersByRoleIdQueryResponseDto>()
            .ForMember(x => x.FullName, opt => opt.MapFrom(x => $"{x.Name} {x.Surname}"));

        CreateMap<UpdateUserCommand, AppUser>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
    }
}