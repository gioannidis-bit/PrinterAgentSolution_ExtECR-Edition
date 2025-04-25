using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("CreditTransactions_Hist")]
public partial class CreditTransactionsHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? CreditAccountId { get; set; }

    public long? CreditCodeId { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

    [Column("CreationTS", TypeName = "datetime")]
    public DateTime? CreationTs { get; set; }

    public byte? Type { get; set; }

    public long? StaffId { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public long? PosInfoId { get; set; }

    public long? EndOfDayId { get; set; }

    public long? InvoiceId { get; set; }

    public long? TransactionId { get; set; }
}
