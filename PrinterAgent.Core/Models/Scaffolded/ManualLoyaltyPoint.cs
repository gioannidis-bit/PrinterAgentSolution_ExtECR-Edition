using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ManualLoyaltyPoint
{
    public int? ManualPointsGained { get; set; }

    public long? ManualPointsRedeemed { get; set; }
}
