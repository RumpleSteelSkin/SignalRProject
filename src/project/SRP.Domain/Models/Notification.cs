using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Notification : Entity<int>
{
    public string? Type { get; set; }
    public string? Icon { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
}