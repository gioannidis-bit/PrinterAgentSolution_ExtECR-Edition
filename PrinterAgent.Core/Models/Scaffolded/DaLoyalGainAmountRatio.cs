using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
[Table("DA_LoyalGainAmountRatio")]
public partial class DaLoyalGainAmountRatio
{
    [Column(TypeName = "decimal(12, 4)")]
    public decimal ToPoints { get; set; }
}
