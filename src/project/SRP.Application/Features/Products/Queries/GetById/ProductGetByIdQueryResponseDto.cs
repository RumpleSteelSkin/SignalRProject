﻿namespace SRP.Application.Features.Products.Queries.GetById;

public class ProductGetByIdQueryResponseDto
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
    public int CategoryID { get; set; }
}