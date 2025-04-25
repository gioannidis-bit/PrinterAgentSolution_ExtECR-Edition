using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class Report
{
    [Column("checkid")]
    public long Checkid { get; set; }

    [Column("invoicetypeid")]
    public long? Invoicetypeid { get; set; }

    public long? Departmentid { get; set; }

    [StringLength(250)]
    public string? DepDescription { get; set; }

    [StringLength(50)]
    public string? Pos { get; set; }

    [StringLength(250)]
    public string? PosDescription { get; set; }

    [Column("fo_dayold", TypeName = "datetime")]
    public DateTime? FoDayold { get; set; }

    [Column("fo_day", TypeName = "datetime")]
    public DateTime? FoDay { get; set; }

    [Column("closeid")]
    public int? Closeid { get; set; }

    [Column("isopen")]
    public int Isopen { get; set; }

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

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Total { get; set; }

    [Column("room")]
    [StringLength(150)]
    public string Room { get; set; } = null!;

    [Column("amount", TypeName = "money")]
    public decimal? Amount { get; set; }

    [Column("vat")]
    public int? Vat { get; set; }

    [StringLength(50)]
    public string? GroupCode { get; set; }

    [StringLength(150)]
    public string? GroupDescription { get; set; }

    [Column("isvoided")]
    public bool Isvoided { get; set; }

    [Column("receipt")]
    public int? Receipt { get; set; }

    [Column("pricelist")]
    [StringLength(50)]
    public string? Pricelist { get; set; }

    [StringLength(500)]
    public string? Pricelistdescription { get; set; }

    [Column("table")]
    [StringLength(50)]
    public string Table { get; set; } = null!;

    [Column("vatB", TypeName = "decimal(9, 4)")]
    public decimal? VatB { get; set; }

    [Column("vatC", TypeName = "decimal(9, 4)")]
    public decimal? VatC { get; set; }

    [Column("cover")]
    public int? Cover { get; set; }

    [Column("accountid")]
    public long? Accountid { get; set; }

    [StringLength(150)]
    public string? Account { get; set; }

    [Column("isdeleted")]
    public bool? Isdeleted { get; set; }

    [StringLength(150)]
    public string RoomOld { get; set; } = null!;
}
