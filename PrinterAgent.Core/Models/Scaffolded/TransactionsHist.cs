using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("Transactions_Hist")]
public partial class TransactionsHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Day { get; set; }

    public long? PosInfoId { get; set; }

    public long? StaffId { get; set; }

    public long? OrderId { get; set; }

    public short? TransactionType { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    public long? DepartmentId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public long? AccountId { get; set; }

    public short? InOut { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Net { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Vat { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Tax { get; set; }

    public long? EndOfDayId { get; set; }

    [StringLength(500)]
    public string? ExtDescription { get; set; }

    public long? InvoicesId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? SupplierId { get; set; }

    [Column("EftTransactionID")]
    [StringLength(500)]
    public string? EftTransactionId { get; set; }

    [StringLength(500)]
    public string? ProviderSignature { get; set; }
}
