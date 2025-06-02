using AutoMapper;
using SRP.Application.Features.Categories.Commands.Add;
using SRP.Application.Features.Categories.Commands.Update;
using SRP.Application.Features.Categories.Queries.GetAll;
using SRP.Application.Features.Categories.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Categories.Profiles;

public class CategoryMapper : Profile
{
    public CategoryMapper()
    {
        CreateMap<CategoryAddCommand, Category>();
        CreateMap<CategoryUpdateCommand, Category>();
        CreateMap<Category, CategoryGetAllQueryResponseDto>();
        CreateMap<Category, CategoryGetByIdQueryResponseDto>();
    }
}