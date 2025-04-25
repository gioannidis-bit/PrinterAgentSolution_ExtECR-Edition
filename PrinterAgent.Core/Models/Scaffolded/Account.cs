using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Account
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public short? Type { get; set; }

    public bool? IsDefault { get; set; }

    public bool? SendsTransfer { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? CardOnly { get; set; }

    public short? KeyboardType { get; set; }

    [Column("PMSPaymentId")]
    public long? PmspaymentId { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    public int? Sort { get; set; }

    [InverseProperty("Account")]
    public virtual ICollection<EndOfDayPaymentAnalysis> EndOfDayPaymentAnalyses { get; set; } = new List<EndOfDayPaymentAnalysis>();

    [InverseProperty("Account")]
    public virtual ICollection<EndOfDayVoidsAnalysis> EndOfDayVoidsAnalyses { get; set; } = new List<EndOfDayVoidsAnalysis>();

    [InverseProperty("Account")]
    public virtual ICollection<EodaccountToPmsTransfer> EodaccountToPmsTransfers { get; set; } = new List<EodaccountToPmsTransfer>();

    [InverseProperty("Account")]
    public virtual ICollection<PosInfoDetailExcludedAccount> PosInfoDetailExcludedAccounts { get; set; } = new List<PosInfoDetailExcludedAccount>();

    [InverseProperty("Account")]
    public virtual ICollection<PosInfo> PosInfos { get; set; } = new List<PosInfo>();

    [InverseProperty("Account")]
    public virtual ICollection<TablePaySuggestion> TablePaySuggestions { get; set; } = new List<TablePaySuggestion>();

    [InverseProperty("Account")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
