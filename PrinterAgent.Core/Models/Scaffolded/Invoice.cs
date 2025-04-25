using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Invoice
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public long? InvoiceTypeId { get; set; }

    public int? Counter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Day { get; set; }

    public bool? IsPrinted { get; set; }

    public long? GuestId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Total { get; set; }

    [Column(TypeName = "money")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Vat { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? Net { get; set; }

    public long? StaffId { get; set; }

    public int? Cover { get; set; }

    public long? TableId { get; set; }

    public long? PosInfoId { get; set; }

    public long? PdaModuleId { get; set; }

    public long? ClientPosId { get; set; }

    public long? EndOfDayId { get; set; }

    public long? PosInfoDetailId { get; set; }

    public bool? IsVoided { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(500)]
    public string? DiscountRemark { get; set; }

    [StringLength(200)]
    public string? PaymentsDesc { get; set; }

    public short IsPaid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PaidTotal { get; set; }

    [StringLength(200)]
    public string? Rooms { get; set; }

    [StringLength(2000)]
    public string? OrderNo { get; set; }

    public bool IsInvoiced { get; set; }

    [StringLength(200)]
    public string? Hashcode { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TableSum { get; set; }

    [StringLength(20)]
    public string? CashAmount { get; set; }

    [StringLength(20)]
    public string? BuzzerNumber { get; set; }

    [Column(TypeName = "money")]
    public decimal? LoyaltyDiscount { get; set; }

    [StringLength(20)]
    public string? ForeignExchangeCurrency { get; set; }

    [Column(TypeName = "money")]
    public decimal? ForeignExchangeTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? ForeignExchangeDiscount { get; set; }

    [Column("ExtECRCode")]
    [StringLength(500)]
    public string? ExtEcrcode { get; set; }

    [StringLength(200)]
    public string? CustomersId { get; set; }

    [StringLength(200)]
    public string? ReservationsId { get; set; }

    [StringLength(100)]
    public string? TcrCode { get; set; }

    [StringLength(200)]
    public string? FiscalServiceNumber { get; set; }

    public string? FiscalServiceResult { get; set; }

    public string? VoidNotes { get; set; }

    [Column("invoiceNumber")]
    public long? InvoiceNumber { get; set; }

    [Column("invoiceFiscalNumber")]
    [StringLength(100)]
    public string? InvoiceFiscalNumber { get; set; }

    [Column(TypeName = "money")]
    public decimal? Tips { get; set; }

    public int? ReservationId { get; set; }

    public bool? IsPrintedViva { get; set; }

    public string? ProviderInformation { get; set; }

    [ForeignKey("ClientPosId")]
    [InverseProperty("Invoices")]
    public virtual ClientPo? ClientPos { get; set; }

    [InverseProperty("Invoice")]
    public virtual ICollection<CreditTransaction> CreditTransactions { get; set; } = new List<CreditTransaction>();

    [ForeignKey("EndOfDayId")]
    [InverseProperty("Invoices")]
    public virtual EndOfDay? EndOfDay { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("Invoices")]
    public virtual Guest? Guest { get; set; }

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceGuestsTran> InvoiceGuestsTrans { get; set; } = new List<InvoiceGuestsTran>();

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceHtmlReceipt> InvoiceHtmlReceipts { get; set; } = new List<InvoiceHtmlReceipt>();

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceQr> InvoiceQrs { get; set; } = new List<InvoiceQr>();

    [InverseProperty("Invoices")]
    public virtual ICollection<InvoiceShippingDetail> InvoiceShippingDetails { get; set; } = new List<InvoiceShippingDetail>();

    [ForeignKey("InvoiceTypeId")]
    [InverseProperty("Invoices")]
    public virtual InvoiceType? InvoiceType { get; set; }

    [InverseProperty("Invoices")]
    public virtual ICollection<Loyalty> Loyalties { get; set; } = new List<Loyalty>();

    [InverseProperty("Invoices")]
    public virtual ICollection<OrderDetailInvoice> OrderDetailInvoices { get; set; } = new List<OrderDetailInvoice>();

    [ForeignKey("PdaModuleId")]
    [InverseProperty("Invoices")]
    public virtual PdaModule? PdaModule { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("Invoices")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("Invoices")]
    public virtual Staff? Staff { get; set; }

    [ForeignKey("TableId")]
    [InverseProperty("Invoices")]
    public virtual Table? Table { get; set; }

    [InverseProperty("Invoices")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
