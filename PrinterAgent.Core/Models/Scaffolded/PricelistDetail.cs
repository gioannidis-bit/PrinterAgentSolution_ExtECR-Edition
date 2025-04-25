using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PricelistDetail")]
public partial class PricelistDetail
{
    [Key]
    public long Id { get; set; }

    public long? PricelistId { get; set; }

    public long? ProductId { get; set; }

    public long? IngredientId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    public long? VatId { get; set; }

    public long? TaxId { get; set; }

    [Column(TypeName = "money")]
    public decimal? PriceWithout { get; set; }

    public int? MinRequiredExtras { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("PricelistDetails")]
    public virtual Ingredient? Ingredient { get; set; }

    [InverseProperty("PriceListDetail")]
    public virtual ICollection<OrderDetailIgredient> OrderDetailIgredients { get; set; } = new List<OrderDetailIgredient>();

    [InverseProperty("PriceListDetail")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("PricelistId")]
    [InverseProperty("PricelistDetails")]
    public virtual Pricelist? Pricelist { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("PricelistDetails")]
    public virtual Product? Product { get; set; }

    [ForeignKey("TaxId")]
    [InverseProperty("PricelistDetails")]
    public virtual Tax? Tax { get; set; }

    [ForeignKey("VatId")]
    [InverseProperty("PricelistDetails")]
    public virtual Vat? Vat { get; set; }
}
