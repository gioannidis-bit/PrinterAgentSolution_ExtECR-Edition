using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class LoyaltyPointsRedeemed
{
    [Column("LoyaltyPointsRedeemed")]
    public int? LoyaltyPointsRedeemed1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }
}
