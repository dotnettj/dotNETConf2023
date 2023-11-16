﻿using ProductServiceEfCore.Repositories;

namespace ProductServiceEfCore.Models;

public class Product : IEntity
{
    public int Id { get; set; }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int SellerId { get; set; }
    public int Stock { get; set; }
    public List<string> Images { get; set; }
}