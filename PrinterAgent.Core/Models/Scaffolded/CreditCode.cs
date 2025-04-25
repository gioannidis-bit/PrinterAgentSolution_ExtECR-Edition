using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class CreditCode
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [StringLength(150)]
    public string? Code { get; set; }

    public byte? Type { get; set; }

    public long? CreditAccountId { get; set; }

    [ForeignKey("CreditAccountId")]
    [InverseProperty("CreditCodes")]
    public virtual CreditAccount? CreditAccount { get; set; }

    [InverseProperty("CreditCode")]
    public virtual ICollection<CreditTransaction> CreditTransactions { get; set; } = new List<CreditTransaction>();

    [InverseProperty("CreditCode")]
    public virtual ICollection<TablePaySuggestion> TablePaySuggestions { get; set; } = new List<TablePaySuggestion>();
}
