using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class CreditAccount
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public long? EndOfDayId { get; set; }

    [Column("ActivateTS", TypeName = "datetime")]
    public DateTime? ActivateTs { get; set; }

    [Column("DeactivateTS", TypeName = "datetime")]
    public DateTime? DeactivateTs { get; set; }

    [InverseProperty("CreditAccount")]
    public virtual ICollection<CreditCode> CreditCodes { get; set; } = new List<CreditCode>();

    [InverseProperty("CreditAccount")]
    public virtual ICollection<CreditTransaction> CreditTransactions { get; set; } = new List<CreditTransaction>();

    [ForeignKey("EndOfDayId")]
    [InverseProperty("CreditAccounts")]
    public virtual EndOfDay? EndOfDay { get; set; }
}
