using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolovataLab1WebApplication.Models;

public partial class OrderedProduct
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код товару")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код замовлення")]
    public int OrderId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Кількість")]
    public int Amount { get; set; }

    //public decimal Price { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код кольору")]
    public int ColorId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код кольору")]
    public virtual Color Color { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код замовлення")]
    public virtual Order Order { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Код товару")]
    public virtual Product Product { get; set; } = null!;
}
