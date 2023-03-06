using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolovataLab1WebApplication.Models;

public partial class ProductType
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Категорія")]
    public string Name { get; set; } = null!;
    

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
