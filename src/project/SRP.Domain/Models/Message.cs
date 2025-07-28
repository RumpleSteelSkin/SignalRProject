using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Message:Entity<int>
{
    public string? Name { get; set; }
    public string? Mail { get; set; }
    public string? Phone { get; set; }
    public string? Subject { get; set; }
    public string? MessageContent { get; set; }
}