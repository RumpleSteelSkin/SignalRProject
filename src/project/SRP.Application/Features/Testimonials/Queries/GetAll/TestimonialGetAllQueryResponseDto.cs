﻿namespace SRP.Application.Features.Testimonials.Queries.GetAll;

public class TestimonialGetAllQueryResponseDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Comment { get; set; }
    public string? ImageUrl { get; set; }
}