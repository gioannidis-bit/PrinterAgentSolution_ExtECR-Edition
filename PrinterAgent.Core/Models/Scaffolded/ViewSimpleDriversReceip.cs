using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewSimpleDriversReceip
{
    [Column("grp")]
    public int Grp { get; set; }

    [Column("id")]
    public long Id { get; set; }

    [Column("stime")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Stime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeChanged { get; set; }

    [Column("status")]
    public long? Status { get; set; }

    [Column("total", TypeName = "money")]
    public decimal? Total { get; set; }

    [StringLength(500)]
    public string CustomerName { get; set; } = null!;

    [StringLength(300)]
    public string ShippingAddress { get; set; } = null!;

    [StringLength(100)]
    public string ShippingCity { get; set; } = null!;

    [StringLength(50)]
    public string ShippingZipCode { get; set; } = null!;

    [StringLength(150)]
    public string Phone { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TransactDay { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    [StringLength(50)]
    public string? FirstName { get; set; }

    [Column("invDay", TypeName = "datetime")]
    public DateTime? InvDay { get; set; }

    [Column("selectDay", TypeName = "datetime")]
    public DateTime? SelectDay { get; set; }

    [Column(TypeName = "money")]
    public decimal? TransactTotal { get; set; }

    [Column("CCTotal", TypeName = "money")]
    public decimal? Cctotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? OnTheRoadTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? OpenCash { get; set; }

    public long EndOfDayId { get; set; }

    [StringLength(150)]
    public string? AccountDescr { get; set; }

    public long? OrderNo { get; set; }

    public int? ReceiptNo { get; set; }
}
