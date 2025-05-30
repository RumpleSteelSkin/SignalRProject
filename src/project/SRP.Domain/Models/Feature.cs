using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Feature : Entity<int>
{
    public string? Title { get; set; }
    public string? Description { get; set; }
}