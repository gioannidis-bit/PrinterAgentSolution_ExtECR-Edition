using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class CreditAccountsView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public long? EndOfDayId { get; set; }

    [Column("ActivateTS", TypeName = "datetime")]
    public DateTime? ActivateTs { get; set; }

    [Column("DeactivateTS", TypeName = "datetime")]
    public DateTime? DeactivateTs { get; set; }
}
