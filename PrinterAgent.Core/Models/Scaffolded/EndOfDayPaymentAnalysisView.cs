using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class EndOfDayPaymentAnalysisView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    public long? EndOfDayId { get; set; }

    public long? AccountId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public short? AccountType { get; set; }
}
