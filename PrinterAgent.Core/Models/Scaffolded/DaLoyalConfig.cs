using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
[Table("DA_LoyalConfig")]
public partial class DaLoyalConfig
{
    public short GainPointsType { get; set; }

    public short RedeemType { get; set; }

    public int MaxPoints { get; set; }

    public int ExpDuration { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal MinAmount { get; set; }

    public int? InitPoints { get; set; }
}
