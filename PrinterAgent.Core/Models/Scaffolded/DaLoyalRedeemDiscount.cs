using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
[Table("DA_LoyalRedeemDiscount")]
public partial class DaLoyalRedeemDiscount
{
    [Column(TypeName = "decimal(12, 4)")]
    public decimal DiscountRatio { get; set; }
}
