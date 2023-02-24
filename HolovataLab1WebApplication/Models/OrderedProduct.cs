using System;
using System.Collections.Generic;

namespace HolovataLab1WebApplication.Models;

public partial class OrderedProduct
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int OrderId { get; set; }

    public int Amount { get; set; }

    public decimal Price { get; set; }

    public int ColorId { get; set; }

    public virtual Color Color { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
