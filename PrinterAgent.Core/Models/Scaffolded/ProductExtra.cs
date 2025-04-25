using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class ProductExtra
{
    [Key]
    public long Id { get; set; }

    public long? ProductId { get; set; }

    public bool? IsRequired { get; set; }

    public long? IngredientId { get; set; }

    public double? MinQty { get; set; }

    public double? MaxQty { get; set; }

    public long? UnitId { get; set; }

    public long? ItemsId { get; set; }

    public long? ProductAsIngridientId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    public int? Sort { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    public bool? CanSavePrice { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("ProductExtras")]
    public virtual Ingredient? Ingredient { get; set; }

    [ForeignKey("ItemsId")]
    [InverseProperty("ProductExtras")]
    public virtual Item? Items { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductExtras")]
    public virtual Product? Product { get; set; }

    [ForeignKey("UnitId")]
    [InverseProperty("ProductExtras")]
    public virtual Unit? Unit { get; set; }
}
