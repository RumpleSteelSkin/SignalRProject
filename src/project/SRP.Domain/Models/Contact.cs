using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Contact : Entity<int>
{
    public string? Location { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public string? FooterDescription { get; set; }
}