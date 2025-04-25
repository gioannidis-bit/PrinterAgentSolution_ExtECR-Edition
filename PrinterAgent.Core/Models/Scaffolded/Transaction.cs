using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Transaction
{
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

    [ForeignKey("AccountId")]
    [InverseProperty("Transactions")]
    public virtual Account? Account { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<CreditTransaction> CreditTransactions { get; set; } = new List<CreditTransaction>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Transactions")]
    public virtual Department? Department { get; set; }

    [ForeignKey("EndOfDayId")]
    [InverseProperty("Transactions")]
    public virtual EndOfDay? EndOfDay { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<InvoiceGuestsTran> InvoiceGuestsTrans { get; set; } = new List<InvoiceGuestsTran>();

    [ForeignKey("InvoicesId")]
    [InverseProperty("Transactions")]
    public virtual Invoice? Invoices { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("Transactions")]
    public virtual Order? Order { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("PosInfoId")]
    [InverseProperty("Transactions")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("Transactions")]
    public virtual Staff? Staff { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("Transactions")]
    public virtual Supplier? Supplier { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<TransferToPm> TransferToPms { get; set; } = new List<TransferToPm>();
}
