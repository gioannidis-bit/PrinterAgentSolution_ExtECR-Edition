using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class CreditTransaction
{
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

    [ForeignKey("CreditAccountId")]
    [InverseProperty("CreditTransactions")]
    public virtual CreditAccount? CreditAccount { get; set; }

    [ForeignKey("CreditCodeId")]
    [InverseProperty("CreditTransactions")]
    public virtual CreditCode? CreditCode { get; set; }

    [ForeignKey("EndOfDayId")]
    [InverseProperty("CreditTransactions")]
    public virtual EndOfDay? EndOfDay { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("CreditTransactions")]
    public virtual Invoice? Invoice { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("CreditTransactions")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("CreditTransactions")]
    public virtual Staff? Staff { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("CreditTransactions")]
    public virtual Transaction? Transaction { get; set; }
}
