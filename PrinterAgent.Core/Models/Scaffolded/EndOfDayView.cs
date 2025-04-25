using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class EndOfDayView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    [Column("FODay", TypeName = "datetime")]
    public DateTime? Foday { get; set; }

    public long? PosInfoId { get; set; }

    public int? CloseId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Net { get; set; }

    public int? TicketsCount { get; set; }

    public int? ItemCount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TicketAverage { get; set; }

    public long? StaffId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Barcodes { get; set; }

    [Column("dtDateTime", TypeName = "datetime")]
    public DateTime? DtDateTime { get; set; }

    [Column("zlogger")]
    [StringLength(120)]
    public string? Zlogger { get; set; }

    [Column("eodPMS", TypeName = "datetime")]
    public DateTime? EodPms { get; set; }
}
