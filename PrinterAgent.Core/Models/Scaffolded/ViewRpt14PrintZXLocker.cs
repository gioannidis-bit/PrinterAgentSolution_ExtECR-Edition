using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt14PrintZXLocker
{
    public long Id { get; set; }

    public bool HasLockers { get; set; }

    public double TotalLockers { get; set; }

    public double TotalLockersAmount { get; set; }

    public double Paidlockers { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PaidlockersAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OccLockers { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OccLockersAmount { get; set; }

    public long? EndOfDayId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndOfDay { get; set; }
}
