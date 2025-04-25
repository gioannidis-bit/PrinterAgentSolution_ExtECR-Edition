using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt02InvoiceProduct
{
    public long? ProductId { get; set; }

    public bool IsExtra { get; set; }

    public long InvoiceId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    public int? InvoiceNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string IsChangeItem { get; set; } = null!;

    [StringLength(150)]
    public string? ItemCode { get; set; }

    [StringLength(150)]
    public string? ItemRemark { get; set; }

    [StringLength(151)]
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

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? ItemTotal { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ItemVatDesc { get; set; }

    public int? ItemVatRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ItemVatValue { get; set; }

    [StringLength(150)]
    public string SalesTypeExtDesc { get; set; } = null!;

    [StringLength(50)]
    public string KitchenId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Time { get; set; }

    public int? RegionPosition { get; set; }

    public string? ItemRegion { get; set; }

    public int ItemSort { get; set; }

    public int ItemPosition { get; set; }

    public int ItemBarcode { get; set; }

    public long OrderDetailId { get; set; }

    public int ItemVatCode { get; set; }
}
