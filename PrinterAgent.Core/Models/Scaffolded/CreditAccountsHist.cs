using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("CreditAccounts_Hist")]
public partial class CreditAccountsHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public long? EndOfDayId { get; set; }

    [Column("ActivateTS", TypeName = "datetime")]
    public DateTime? ActivateTs { get; set; }

    [Column("DeactivateTS", TypeName = "datetime")]
    public DateTime? DeactivateTs { get; set; }
}
