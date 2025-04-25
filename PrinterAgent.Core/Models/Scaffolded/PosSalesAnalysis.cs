using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class PosSalesAnalysis
{
    public long? DepartmentId { get; set; }

    [StringLength(250)]
    public string? DepartmentDescription { get; set; }

    public long? PosInfoId { get; set; }

    [StringLength(250)]
    public string? PosInfoDescription { get; set; }

    public long? CategoryId { get; set; }

    [StringLength(500)]
    public string? CategoryDescription { get; set; }

    [StringLength(50)]
    public string? ProductCategoryCode { get; set; }

    [StringLength(150)]
    public string? ProductCategoryDescription { get; set; }

    public long DetailedInvoiceId { get; set; }

    public long? ProductId { get; set; }

    [StringLength(150)]
    public string? ProductCode { get; set; }

    [StringLength(50)]
    public string? ProductDescription { get; set; }

    public double? Qty { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [Column(TypeName = "money")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? Total { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Net { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? VatAmount { get; set; }

    [Column(TypeName = "decimal(8, 4)")]
    public decimal? VatPercentage { get; set; }

    public long? PricelistId { get; set; }

    [StringLength(50)]
    public string? PricelistCode { get; set; }

    [StringLength(500)]
    public string? PricelistDescription { get; set; }

    public long? VatId { get; set; }

    [Column(TypeName = "money")]
    public decimal? InvoiceTotal { get; set; }

    public long InvoiceId { get; set; }

    public int? InvoiceType { get; set; }

    [StringLength(50)]
    public string? Abbreviation { get; set; }

    public long? ReceiptNo { get; set; }

    public int? Cover { get; set; }

    [StringLength(200)]
    public string? Rooms { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    public long? SalesTypeId { get; set; }

    [StringLength(150)]
    public string? SalesTypeDescription { get; set; }

    [StringLength(50)]
    public string? StaffCode { get; set; }

    [StringLength(101)]
    public string StafName { get; set; } = null!;

    [Column("FODay", TypeName = "datetime")]
    public DateTime? Foday { get; set; }

    public long EndOfDayId { get; set; }

    public bool IsExtra { get; set; }

    public long? AccountId { get; set; }

    public short? AccountType { get; set; }

    [StringLength(150)]
    public string? AccountDescription { get; set; }
}
