using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("Order_Hist")]
public partial class OrderHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? OrderNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Day { get; set; }

    [Column(TypeName = "money")]
    public decimal? Total { get; set; }

    public long? PosId { get; set; }

    public long? StaffId { get; set; }

    public long? EndOfDayId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Discount { get; set; }

    public int? ReceiptNo { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? TotalBeforeDiscount { get; set; }

    public long? PdaModuleId { get; set; }

    public long? ClientPosId { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ExtType { get; set; }

    [Unicode(false)]
    public string? ExtObj { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ExtKey { get; set; }

    public int? OrderOrigin { get; set; }

    public int? Couver { get; set; }

    [Column("DA_IsPaid")]
    public bool? DaIsPaid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EstTakeoutDate { get; set; }

    public bool? IsDelay { get; set; }

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

    [Column(TypeName = "text")]
    public string? LogicErrors { get; set; }

    public bool? ItemsChanged { get; set; }

    [Column("DA_Origin")]
    public short? DaOrigin { get; set; }

    [StringLength(200)]
    public string? LoyaltyCode { get; set; }

    [StringLength(30)]
    public string? TelephoneNumber { get; set; }

    public int? CouverAdults { get; set; }

    public int? CouverChildren { get; set; }

    public Guid? MacroGuidId { get; set; }

    [StringLength(150)]
    public string? GuestFirstName { get; set; }

    [StringLength(150)]
    public string? GuestLastName { get; set; }

    [StringLength(150)]
    public string? Room { get; set; }

    public bool? HasKdsId { get; set; }

    public bool? UseNfcCard { get; set; }

    public long? DeliveryRoutingId { get; set; }

    public bool? IsReceived { get; set; }

    [StringLength(150)]
    public string? GlobalOrderId { get; set; }

    public Guid? UseAllowanceMacroGuidId { get; set; }

    public bool? IsPrintedKdsOrderId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LoyaltyExtKey { get; set; }
}
