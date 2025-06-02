using MediatR;

namespace SRP.Application.Features.Categories.Commands.Delete;

public class CategoryDeleteCommand:IRequest<string>
{
    public int Id { get; set; }
}