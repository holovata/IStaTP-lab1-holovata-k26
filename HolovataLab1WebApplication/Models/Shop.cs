using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolovataLab1WebApplication.Models;

public partial class Shop
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Адреса")]
    public string Address { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
