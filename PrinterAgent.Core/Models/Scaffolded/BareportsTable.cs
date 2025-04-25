using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
[Table("BAReports_table")]
public partial class BareportsTable
{
    [Column("checkid")]
    public long Checkid { get; set; }

    [Column("invoicetypeid")]
    public long? Invoicetypeid { get; set; }

    [StringLength(50)]
    public string? Abbreviation { get; set; }

    public long? Departmentid { get; set; }

    [StringLength(250)]
    public string? DepDescription { get; set; }

    [StringLength(50)]
    public string? Pos { get; set; }

    [StringLength(250)]
    public string? PosDescription { get; set; }

    [Column("fo_dayold", TypeName = "datetime")]
    public DateTime? FoDayold { get; set; }

    [Column("table")]
    public int Table { get; set; }

    [StringLength(150)]
    public string? Account { get; set; }

    [Column("isdeleted")]
    public int Isdeleted { get; set; }

    public int RoomOld { get; set; }

    [Column("fo_day", TypeName = "datetime")]
    public DateTime? FoDay { get; set; }

    [Column("room")]
    [StringLength(150)]
    public string Room { get; set; } = null!;

    [Column("vat")]
    public int Vat { get; set; }

    [Column("vata")]
    public int Vata { get; set; }

    [Column("vatB")]
    public int VatB { get; set; }

    [Column("vatC")]
    public int VatC { get; set; }

    [Column("cover")]
    public int Cover { get; set; }

    [Column("closeid")]
    public int? Closeid { get; set; }

    [Column("isopen")]
    public int Isopen { get; set; }

    [Column("accountid")]
    public int Accountid { get; set; }

    [Column("rec_time", TypeName = "datetime")]
    public DateTime? RecTime { get; set; }

    [Column("waiter")]
    [StringLength(50)]
    public string? Waiter { get; set; }

    [Column("waiterName")]
    [StringLength(50)]
    public string? WaiterName { get; set; }

    [Column("productcode")]
    public long? Productcode { get; set; }

    [StringLength(50)]
    public string? ProductDescription { get; set; }

    public double? Qty { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? Total { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Net { get; set; }

    [Column(TypeName = "decimal(22, 4)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalBeforeDiscount { get; set; }

    [Column("amount", TypeName = "money")]
    public decimal? Amount { get; set; }

    [StringLength(50)]
    public string? GroupCode { get; set; }

    [StringLength(150)]
    public string GroupDescription { get; set; } = null!;

    [Column("isvoided")]
    public bool Isvoided { get; set; }

    [Column("receipt")]
    public int? Receipt { get; set; }

    [Column("pricelist")]
    [StringLength(50)]
    public string? Pricelist { get; set; }

    [StringLength(500)]
    public string? Pricelistdescription { get; set; }

    [StringLength(500)]
    public string? CategoryDescr { get; set; }

    [StringLength(150)]
    public string BoardCode { get; set; } = null!;
}
