﻿namespace SRP.WebUI.Dtos.Basket;

public class ResultBasketDto
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }
    public int ProductID { get; set; }
    public string? ProductName { get; set; }
    public int MenuTableID { get; set; }
}