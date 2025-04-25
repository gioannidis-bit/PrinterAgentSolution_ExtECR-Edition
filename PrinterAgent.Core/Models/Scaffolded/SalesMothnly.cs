using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class SalesMothnly
{
    [Column("FODay", TypeName = "datetime")]
    public DateTime? Foday { get; set; }

    public long? OrdesNoDiveIn { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? SalesDiveIn { get; set; }

    public double? NetSalesDiveIn { get; set; }

    public long? OrdersDelivery { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? SalesDelivery { get; set; }

    public double? SalesNetDelivery { get; set; }

    public long? OrdersTakeOut { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? SalesTakeOut { get; set; }

    public double? SalesNetTakeOut { get; set; }
}
