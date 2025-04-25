using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Ingredient
{
    [Key]
    public long Id { get; set; }

    [StringLength(70)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? ExtendedDescription { get; set; }

    [StringLength(500)]
    public string? SalesDescription { get; set; }

    public double? Qty { get; set; }

    public long? ItemId { get; set; }

    public long? UnitId { get; set; }

    [StringLength(150)]
    public string? Code { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(25)]
    public string? Background { get; set; }

    [StringLength(25)]
    public string? Color { get; set; }

    public long? IngredientCategoryId { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    public bool? DisplayOnKds { get; set; }

    [ForeignKey("IngredientCategoryId")]
    [InverseProperty("Ingredients")]
    public virtual IngredientCategory? IngredientCategory { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("Ingredients")]
    public virtual Item? Item { get; set; }

    [InverseProperty("Ingredient")]
    public virtual ICollection<OrderDetailIgredient> OrderDetailIgredients { get; set; } = new List<OrderDetailIgredient>();

    [InverseProperty("Ingredient")]
    public virtual ICollection<PricelistDetail> PricelistDetails { get; set; } = new List<PricelistDetail>();

    [InverseProperty("Ingredient")]
    public virtual ICollection<ProductExtra> ProductExtras { get; set; } = new List<ProductExtra>();

    [InverseProperty("Ingredient")]
    public virtual ICollection<ProductRecipe> ProductRecipes { get; set; } = new List<ProductRecipe>();

    [ForeignKey("UnitId")]
    [InverseProperty("Ingredients")]
    public virtual Unit? Unit { get; set; }
}
