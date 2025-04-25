using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Item
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? ExtendedDescription { get; set; }

    public double? Qty { get; set; }

    public long? UnitId { get; set; }

    public long? VatId { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    [InverseProperty("Items")]
    public virtual ICollection<ProductExtra> ProductExtras { get; set; } = new List<ProductExtra>();

    [InverseProperty("Items")]
    public virtual ICollection<ProductRecipe> ProductRecipes { get; set; } = new List<ProductRecipe>();

    [ForeignKey("UnitId")]
    [InverseProperty("Items")]
    public virtual Unit? Unit { get; set; }

    [ForeignKey("VatId")]
    [InverseProperty("Items")]
    public virtual Vat? Vat { get; set; }
}
