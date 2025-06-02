using MediatR;

namespace SRP.Application.Features.Categories.Commands.Update;

public class CategoryUpdateCommand : IRequest<string>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Status { get; set; }
}