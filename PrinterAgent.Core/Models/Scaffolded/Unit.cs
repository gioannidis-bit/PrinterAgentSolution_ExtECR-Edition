using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Unit
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? Abbreviation { get; set; }

    [Column("Unit")]
    public double? Unit1 { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [InverseProperty("Unit")]
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    [InverseProperty("Unit")]
    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    [InverseProperty("Unit")]
    public virtual ICollection<ProductExtra> ProductExtras { get; set; } = new List<ProductExtra>();

    [InverseProperty("Unit")]
    public virtual ICollection<ProductRecipe> ProductRecipes { get; set; } = new List<ProductRecipe>();

    [InverseProperty("Unit")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
