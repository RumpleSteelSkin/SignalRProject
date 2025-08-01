﻿using Core.Persistence.Entities;

namespace SRP.Domain.Models;

public class Booking : Entity<int>
{
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public string? Description { get; set; }
    public int? PersonCount { get; set; }
    public DateTime Date { get; set; }
}