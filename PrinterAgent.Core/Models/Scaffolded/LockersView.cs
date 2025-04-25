using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class LockersView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    public bool? HasLockers { get; set; }

    public double? TotalLockers { get; set; }

    public double? TotalLockersAmount { get; set; }

    public double? Paidlockers { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PaidlockersAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? OccLockers { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? OccLockersAmount { get; set; }

    public long? EndOfDayId { get; set; }

    public long? PosInfoId { get; set; }

    public int TotalCash { get; set; }

    public int TotalSplashCash { get; set; }

    public int ReturnCash { get; set; }

    public int ReturnSplashCash { get; set; }

    public int CloseCash { get; set; }

    public int CloseSplashCash { get; set; }
}
