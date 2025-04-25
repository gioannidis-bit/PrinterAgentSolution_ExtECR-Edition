using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt15PrintZXInvoicesAnalisi
{
    public long? EndOfDayId { get; set; }

    public long? PosInfoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Time { get; set; }

    public long? InvoiceTypeId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Total { get; set; }

    [Column("13 %", TypeName = "decimal(38, 2)")]
    public decimal _13 { get; set; }

    [Column("24 %", TypeName = "decimal(38, 2)")]
    public decimal _24 { get; set; }

    public int? Counter { get; set; }

    [StringLength(101)]
    public string Driver { get; set; } = null!;

    public bool? IsVoided { get; set; }

    [Column("FODay", TypeName = "datetime")]
    public DateTime? Foday { get; set; }
}
