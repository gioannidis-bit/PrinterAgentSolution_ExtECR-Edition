using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
[Table("webposrepos_table")]
public partial class WebposreposTable
{
    public int StoreId { get; set; }

    [Column("invoiceTypeAbrev")]
    [StringLength(50)]
    public string? InvoiceTypeAbrev { get; set; }

    [Column("invoiceTypeDescr")]
    [StringLength(17)]
    public string? InvoiceTypeDescr { get; set; }

    [Column("checkid")]
    public long Checkid { get; set; }

    public long? Invoicetypeid { get; set; }

    public long? Departmentid { get; set; }

    [StringLength(250)]
    public string? DepDescription { get; set; }

    [StringLength(50)]
    public string? Pos { get; set; }

    [StringLength(250)]
    public string? PosDescription { get; set; }

    [Column("fo_dayold")]
    [StringLength(8)]
    [Unicode(false)]
    public string? FoDayold { get; set; }

    [Column("fo_day", TypeName = "datetime")]
    public DateTime? FoDay { get; set; }

    [Column("posid")]
    public long? Posid { get; set; }

    [Column("accountid")]
    public int Accountid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Account { get; set; } = null!;

    [Column("closeid")]
    public int? Closeid { get; set; }

    [Column("isopen")]
    public int Isopen { get; set; }

    [Column("rec_time")]
    [StringLength(8)]
    [Unicode(false)]
    public string? RecTime { get; set; }

    [Column("waiter")]
    [StringLength(50)]
    public string? Waiter { get; set; }

    [Column("waiterName")]
    [StringLength(50)]
    public string? WaiterName { get; set; }

    [Column("productcode")]
    public long? Productcode { get; set; }

    [Column("productid")]
    [StringLength(150)]
    public string? Productid { get; set; }

    [Column("productdescription")]
    [StringLength(70)]
    public string? Productdescription { get; set; }

    [Column("qty")]
    public double? Qty { get; set; }

    [Column("total", TypeName = "decimal(21, 4)")]
    public decimal? Total { get; set; }

    [Column("room")]
    [StringLength(150)]
    public string Room { get; set; } = null!;

    [Column("amount", TypeName = "decimal(21, 4)")]
    public decimal? Amount { get; set; }

    [Column("vat")]
    public int? Vat { get; set; }

    [Column("groupcode")]
    [StringLength(50)]
    public string? Groupcode { get; set; }

    [Column("groupdescription")]
    [StringLength(150)]
    public string? Groupdescription { get; set; }

    [Column("isvoided")]
    public bool Isvoided { get; set; }

    [Column("receipt")]
    public int? Receipt { get; set; }

    [Column("pricelist")]
    [StringLength(50)]
    public string Pricelist { get; set; } = null!;

    [Column("pricelistdescription")]
    [StringLength(500)]
    public string Pricelistdescription { get; set; } = null!;

    [Column("table")]
    [StringLength(50)]
    public string Table { get; set; } = null!;

    [Column("vatb", TypeName = "decimal(20, 4)")]
    public decimal? Vatb { get; set; }

    [Column("vatc", TypeName = "decimal(20, 4)")]
    public decimal? Vatc { get; set; }

    [Column("cover")]
    public int? Cover { get; set; }

    [Column("isdeleted")]
    public bool? Isdeleted { get; set; }

    [Column("roomold")]
    [StringLength(150)]
    public string Roomold { get; set; } = null!;

    [Column("category")]
    [StringLength(500)]
    public string Category { get; set; } = null!;

    [Column("categoryid")]
    public long Categoryid { get; set; }

    public bool? IsExtra { get; set; }

    [Column("totalnet")]
    public int Totalnet { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArrivalDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DepartureDate { get; set; }

    public int? ProfileNo { get; set; }

    [StringLength(150)]
    public string FirstName { get; set; } = null!;

    [StringLength(150)]
    public string? LastName { get; set; }

    [StringLength(150)]
    public string Counrty { get; set; } = null!;

    [StringLength(150)]
    public string? Birthday { get; set; }

    [Column("adults")]
    public int? Adults { get; set; }

    [Column("children")]
    public int? Children { get; set; }

    [Column("boardname")]
    [StringLength(150)]
    public string Boardname { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string BlackCard { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? Discount { get; set; }

    [Column("cancelReason")]
    [StringLength(1500)]
    public string? CancelReason { get; set; }

    [StringLength(500)]
    public string? DiscountReason { get; set; }
}
