using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewSimpleTameio
{
    [Column("grp")]
    public int Grp { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public int? Receipts { get; set; }

    [Column("totalAmount")]
    public double? TotalAmount { get; set; }

    [Column("invDay", TypeName = "datetime")]
    public DateTime? InvDay { get; set; }

    public long EndOfDayId { get; set; }
}
