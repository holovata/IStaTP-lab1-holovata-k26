using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolovataLab1WebApplication.Models;

public partial class ProductsColor
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код товару")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код кольору")]
    public int ColorId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Доступність (0/1)")]
    public int? Availability { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код кольору")]
    public virtual Color Color { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код товару")]
    public virtual Product Product { get; set; } = null!;
}
