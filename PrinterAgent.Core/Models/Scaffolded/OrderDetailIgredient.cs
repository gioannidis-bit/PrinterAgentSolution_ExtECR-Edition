using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class OrderDetailIgredient
{
    [Key]
    public long Id { get; set; }

    public long? IngredientId { get; set; }

    public double? Qty { get; set; }

    public long? UnitId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    public long? OrderDetailId { get; set; }

    public long? PriceListDetailId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? TotalAfterDiscount { get; set; }

    public bool? IsDeleted { get; set; }

    public double? PendingQty { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("OrderDetailIgredients")]
    public virtual Ingredient? Ingredient { get; set; }

    [ForeignKey("OrderDetailId")]
    [InverseProperty("OrderDetailIgredients")]
    public virtual OrderDetail? OrderDetail { get; set; }

    [InverseProperty("OrderDetailIgredients")]
    public virtual ICollection<OrderDetailIgredientVatAnal> OrderDetailIgredientVatAnals { get; set; } = new List<OrderDetailIgredientVatAnal>();

    [InverseProperty("OrderDetailIgredients")]
    public virtual ICollection<OrderDetailInvoice> OrderDetailInvoices { get; set; } = new List<OrderDetailInvoice>();

    [ForeignKey("PriceListDetailId")]
    [InverseProperty("OrderDetailIgredients")]
    public virtual PricelistDetail? PriceListDetail { get; set; }
}
