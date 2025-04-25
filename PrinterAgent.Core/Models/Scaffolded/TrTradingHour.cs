using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
[Table("TR_TradingHours")]
public partial class TrTradingHour
{
    public TimeOnly? TimeFrom { get; set; }

    public TimeOnly? TimeTo { get; set; }
}
