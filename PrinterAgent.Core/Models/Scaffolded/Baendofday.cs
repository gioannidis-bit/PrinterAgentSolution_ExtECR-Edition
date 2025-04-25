using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class Baendofday
{
    [StringLength(250)]
    public string? Description { get; set; }

    [Column("foday", TypeName = "datetime")]
    public DateTime? Foday { get; set; }

    [Column("closeid")]
    public int? Closeid { get; set; }

    [StringLength(150)]
    public string? Account { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Net { get; set; }

    public int? TicketsCount { get; set; }

    public int? ItemCount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TicketAverage { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndofdayTime { get; set; }

    [Column("cover")]
    public double? Cover { get; set; }
}
