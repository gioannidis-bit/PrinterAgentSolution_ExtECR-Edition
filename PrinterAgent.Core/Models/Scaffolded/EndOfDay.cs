using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("EndOfDay")]
public partial class EndOfDay
{
    [Key]
    public long Id { get; set; }

    [Column("FODay", TypeName = "datetime")]
    public DateTime? Foday { get; set; }

    public long? PosInfoId { get; set; }

    public int? CloseId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Net { get; set; }

    public int? TicketsCount { get; set; }

    public int? ItemCount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TicketAverage { get; set; }

    public long? StaffId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Barcodes { get; set; }

    [Column("dtDateTime", TypeName = "datetime")]
    public DateTime? DtDateTime { get; set; }

    [Column("zlogger")]
    [StringLength(120)]
    public string? Zlogger { get; set; }

    [Column("eodPMS", TypeName = "datetime")]
    public DateTime? EodPms { get; set; }

    [InverseProperty("EndOfDay")]
    public virtual ICollection<CreditAccount> CreditAccounts { get; set; } = new List<CreditAccount>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<CreditTransaction> CreditTransactions { get; set; } = new List<CreditTransaction>();

    [InverseProperty("EndOfday")]
    public virtual ICollection<EndOfDayDetail> EndOfDayDetails { get; set; } = new List<EndOfDayDetail>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<EndOfDayPaymentAnalysis> EndOfDayPaymentAnalyses { get; set; } = new List<EndOfDayPaymentAnalysis>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<EndOfDayVoidsAnalysis> EndOfDayVoidsAnalyses { get; set; } = new List<EndOfDayVoidsAnalysis>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<KitchenInstructionLogger> KitchenInstructionLoggers { get; set; } = new List<KitchenInstructionLogger>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<Locker> Lockers { get; set; } = new List<Locker>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<MealConsumption> MealConsumptions { get; set; } = new List<MealConsumption>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<OrderDetailInvoice> OrderDetailInvoices { get; set; } = new List<OrderDetailInvoice>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [ForeignKey("PosInfoId")]
    [InverseProperty("EndOfDays")]
    public virtual PosInfo? PosInfo { get; set; }

    [InverseProperty("EndOfDay")]
    public virtual ICollection<StaffCash> StaffCashes { get; set; } = new List<StaffCash>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [InverseProperty("EndOfDay")]
    public virtual ICollection<TransferToPm> TransferToPms { get; set; } = new List<TransferToPm>();
}
