using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("OrderDetailIgredients_Hist")]
public partial class OrderDetailIgredientsHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

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
}
