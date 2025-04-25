using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class OrderDetailInvoicesView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    public long? OrderDetailId { get; set; }

    public long? StaffId { get; set; }

    public long? PosInfoDetailId { get; set; }

    public long? Counter { get; set; }

    [Column("CreationTS", TypeName = "datetime")]
    public DateTime? CreationTs { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CustomerId { get; set; }

    public long? InvoicesId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? OrderDetailIgredientsId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [Column(TypeName = "money")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Net { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? VatRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? VatAmount { get; set; }

    public long? VatId { get; set; }

    public long? TaxId { get; set; }

    public int? VatCode { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? TaxAmount { get; set; }

    public double? Qty { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? Total { get; set; }

    public long? PricelistId { get; set; }

    public long? ProductId { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [StringLength(150)]
    public string? ItemCode { get; set; }

    [StringLength(150)]
    public string? ItemRemark { get; set; }

    public int? InvoiceType { get; set; }

    public long? TableId { get; set; }

    [StringLength(50)]
    public string? TableCode { get; set; }

    public long? RegionId { get; set; }

    public long? OrderNo { get; set; }

    public long? OrderId { get; set; }

    public bool IsExtra { get; set; }

    public long? PosInfoId { get; set; }

    public long? EndOfDayId { get; set; }

    [StringLength(50)]
    public string? Abbreviation { get; set; }

    public long? DiscountId { get; set; }

    public long? SalesTypeId { get; set; }

    public long? ProductCategoryId { get; set; }

    public long? CategoryId { get; set; }

    public int ItemPosition { get; set; }

    public int ItemSort { get; set; }

    public string? ItemRegion { get; set; }

    public int? RegionPosition { get; set; }

    public int ItemBarcode { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalBeforeDiscount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalAfterDiscount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ReceiptSplitedDiscount { get; set; }

    [StringLength(150)]
    public string? TableLabel { get; set; }
}
