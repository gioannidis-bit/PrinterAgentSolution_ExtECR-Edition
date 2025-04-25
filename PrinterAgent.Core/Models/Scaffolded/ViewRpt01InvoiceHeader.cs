using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt01InvoiceHeader
{
    public long InvoiceId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TableTotal { get; set; }

    public int PaymentTypeId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string PrintKitchen { get; set; } = null!;

    [StringLength(250)]
    public string? ReceiptTypeDescription { get; set; }

    [StringLength(250)]
    public string? DepartmentTypeDescription { get; set; }

    public int? PaidAmount { get; set; }

    [StringLength(150)]
    public string? SalesTypeDescription { get; set; }

    public int? ItemsCount { get; set; }

    public int Couver { get; set; }

    public int? PrintFiscalSign { get; set; }

    public int FiscalType { get; set; }

    public int? DetailsId { get; set; }

    public short? InvoiceIndex { get; set; }

    [StringLength(50)]
    public string TableNo { get; set; } = null!;

    [StringLength(150)]
    public string Room { get; set; } = null!;

    [StringLength(50)]
    public string Waiter { get; set; } = null!;

    [StringLength(50)]
    public string WaiterNo { get; set; } = null!;

    public long? Pos { get; set; }

    [StringLength(250)]
    public string PosDescr { get; set; } = null!;

    [StringLength(250)]
    public string? DepartmentDesc { get; set; }

    public long? Department { get; set; }

    [StringLength(150)]
    public string? AccountDescription { get; set; }

    [StringLength(500)]
    public string? CustomerName { get; set; }

    [StringLength(300)]
    public string CustomerAddress { get; set; } = null!;

    [StringLength(300)]
    public string CustomerDeliveryAddress { get; set; } = null!;

    [StringLength(150)]
    public string CustomerPhone { get; set; } = null!;

    [StringLength(200)]
    public string Floor { get; set; } = null!;

    [StringLength(100)]
    public string City { get; set; } = null!;

    [StringLength(1500)]
    public string CustomerComments { get; set; } = null!;

    [StringLength(100)]
    public string CustomerAfm { get; set; } = null!;

    [StringLength(100)]
    public string CustomerDoy { get; set; } = null!;

    [StringLength(100)]
    public string CustomerJob { get; set; } = null!;

    [StringLength(100)]
    public string CompanyName { get; set; } = null!;

    public int? RegNo { get; set; }

    public int? SumOfLunches { get; set; }

    public int? SumofConsumedLunches { get; set; }

    [StringLength(150)]
    public string GuestTerm { get; set; } = null!;

    public int Adults { get; set; }

    public int Kids { get; set; }

    public short? InvoiceType { get; set; }

    public int TotalVat { get; set; }

    public int TotalVat1 { get; set; }

    public int TotalVat2 { get; set; }

    public int TotalVat3 { get; set; }

    public int TotalVat4 { get; set; }

    public int TotalVat5 { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalDiscount { get; set; }

    public int Bonus { get; set; }

    public int PriceList { get; set; }

    public int? ReceiptNo { get; set; }

    [StringLength(2000)]
    public string? OrderNo { get; set; }

    public int? OrderComments { get; set; }

    [Column(TypeName = "money")]
    public decimal TotalNet { get; set; }

    [Column(TypeName = "money")]
    public decimal Total { get; set; }

    public int? Change { get; set; }

    [StringLength(20)]
    public string CashAmount { get; set; } = null!;

    [StringLength(20)]
    public string BuzzerNumber { get; set; } = null!;

    public bool? IsVoid { get; set; }

    public int? CreditTransactions { get; set; }

    [Column("start_time", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [StringLength(50)]
    public string? Payment { get; set; }

    public int? ExtType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryTime { get; set; }

    [Column("paymentMethod")]
    public string? PaymentMethod { get; set; }

    [StringLength(100)]
    public string ShippingCity { get; set; } = null!;

    [Column("invoiceTypeDescr")]
    [StringLength(9)]
    [Unicode(false)]
    public string InvoiceTypeDescr { get; set; } = null!;

    public string BellName { get; set; } = null!;

    [StringLength(19)]
    [Unicode(false)]
    public string CouverDescr { get; set; } = null!;

    [StringLength(50)]
    public string BillingZipCode { get; set; } = null!;

    [StringLength(50)]
    public string ShippingZipCode { get; set; } = null!;

    public string ShippingCompany { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? ExtKey { get; set; }

    [Column("rendezvous")]
    public int Rendezvous { get; set; }

    [Column("recievDate", TypeName = "datetime")]
    public DateTime? RecievDate { get; set; }

    [StringLength(1500)]
    public string? OrderNotes { get; set; }

    [StringLength(1500)]
    public string? StoreNotes { get; set; }

    [StringLength(1500)]
    public string? CustomerNotes { get; set; }

    [StringLength(1500)]
    public string? CustomerSecretNotes { get; set; }

    [StringLength(1500)]
    public string? CustomerLastOrderNotes { get; set; }

    [Column("DA_IsPaid")]
    public bool? DaIsPaid { get; set; }

    public bool? IsDelay { get; set; }

    public bool? ItemsChanged { get; set; }

    [StringLength(1500)]
    public string ShippingNotes { get; set; } = null!;

    [StringLength(1500)]
    public string BillingNotes { get; set; } = null!;

    [Column("endofdayid")]
    public long Endofdayid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceivedTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparingTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadyTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnroadTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CanceledTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompleteTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnedTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EstTakeoutDate { get; set; }

    public int DelayedOrder { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DelayedTime { get; set; }

    public long? Status { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? MaxStatusDescr { get; set; }

    public int OrderOrigin { get; set; }

    [Column("DA_Origin")]
    public short DaOrigin { get; set; }
}
