using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_LoyalGainAmountRange")]
public partial class DaLoyalGainAmountRange
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal FromAmount { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal ToAmount { get; set; }

    public int Points { get; set; }
}
