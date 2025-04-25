using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt12PrintZXVoidsAnalysis
{
    [StringLength(150)]
    public string? Description { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    public long? EndOfDayId { get; set; }

    public long? PosInfoId { get; set; }
}
