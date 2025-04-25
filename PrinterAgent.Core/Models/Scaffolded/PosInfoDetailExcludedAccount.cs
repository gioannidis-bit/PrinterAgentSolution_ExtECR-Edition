using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfoDetail_Excluded_Accounts")]
public partial class PosInfoDetailExcludedAccount
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoDetailId { get; set; }

    public long? AccountId { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("PosInfoDetailExcludedAccounts")]
    public virtual Account? Account { get; set; }

    [ForeignKey("PosInfoDetailId")]
    [InverseProperty("PosInfoDetailExcludedAccounts")]
    public virtual PosInfoDetail? PosInfoDetail { get; set; }
}
