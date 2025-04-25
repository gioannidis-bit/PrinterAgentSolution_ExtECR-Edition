using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class TablePaySuggestionView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    public long? AccountId { get; set; }

    public long? GuestId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Amount { get; set; }

    public long? OrderDetailId { get; set; }

    public bool? IsUsed { get; set; }

    public long? CreditCodeId { get; set; }
}
