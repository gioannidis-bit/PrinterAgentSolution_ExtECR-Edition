using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class BoardMeal
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? BoardId { get; set; }

    [StringLength(100)]
    public string? BoardDescription { get; set; }

    public long? ProductId { get; set; }

    public int? MealsQty { get; set; }

    [StringLength(50)]
    public string? BoardCode { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("BoardMeals")]
    public virtual Product? Product { get; set; }
}
