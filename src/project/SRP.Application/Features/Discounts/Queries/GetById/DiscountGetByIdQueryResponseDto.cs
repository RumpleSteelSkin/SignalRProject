﻿namespace SRP.Application.Features.Discounts.Queries.GetById;

public class DiscountGetByIdQueryResponseDto
{
    public string? Title { get; set; }
    public string? Amount { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
}