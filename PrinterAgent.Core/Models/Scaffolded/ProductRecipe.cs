using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ProductRecipe")]
public partial class ProductRecipe
{
    [Key]
    public long Id { get; set; }

    public long? ProductId { get; set; }

    public long? IngredientId { get; set; }

    public long? UnitId { get; set; }

    public double? Qty { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    public byte? IsProduct { get; set; }

    public double? MinQty { get; set; }

    public double? MaxQty { get; set; }

    public long? ItemsId { get; set; }

    public long? ProductAsIngridientId { get; set; }

    public double? DefaultQty { get; set; }

    public int? Sort { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    public bool? CanSavePrice { get; set; }

    public bool? ExtFlag { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("ProductRecipes")]
    public virtual Ingredient? Ingredient { get; set; }

    [ForeignKey("ItemsId")]
    [InverseProperty("ProductRecipes")]
    public virtual Item? Items { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductRecipes")]
    public virtual Product? Product { get; set; }

    [ForeignKey("UnitId")]
    [InverseProperty("ProductRecipes")]
    public virtual Unit? Unit { get; set; }
}
