using System;
using System.Collections.Generic;

namespace HolovataLab1WebApplication.Models;

public partial class Shop
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
