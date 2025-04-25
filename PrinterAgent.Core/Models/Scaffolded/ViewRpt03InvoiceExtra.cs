using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt03InvoiceExtra
{
    public long? ProductId { get; set; }

    public long? InvoicesId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string IsChangeItem { get; set; } = null!;

    [StringLength(150)]
    public string? ItemCode { get; set; }

    [StringLength(150)]
    public string? ItemDescr { get; set; }

    [Column(TypeName = "money")]
    public decimal? ItemDiscount { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? ItemGross { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ItemNet { get; set; }

    [Column(TypeName = "money")]
    public decimal? ItemPrice { get; set; }

    public double? ItemQty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ItemVatDesc { get; set; }

    public int? ItemVatRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ItemVatValue { get; set; }

    public long? OrderDetailId { get; set; }

    public int ItemVatCode { get; set; }
}
