using System;

namespace Core.Entities;

public class Product: BaseEntity
{
    public required string name { get; set; }
    public required string Description { get; set; }
    public decimal price { get; set; }
    public required string PictureUrl { get; set; }
    public required string type { get; set; }
    public required string Brand { get; set; }
    public int QuantityInStock { get; set; }

}
