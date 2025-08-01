﻿using SRP.Domain.Models;

namespace SRP.Application.Features.Baskets.Queries.GetById;

public class BasketGetByIdQueryResponseDto
{
    public decimal Price { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }
    public int ProductID { get; set; }
    public int MenuTableID { get; set; }
}