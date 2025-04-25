using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Order")]
public partial class Order
{
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

    public long? DeliveryRoutingId { get; set; }

    [StringLength(150)]
    public string? GuestFirstName { get; set; }

    [StringLength(150)]
    public string? GuestLastName { get; set; }

    [StringLength(150)]
    public string? Room { get; set; }

    public bool? HasKdsId { get; set; }

    public bool? UseNfcCard { get; set; }

    public bool? IsReceived { get; set; }

    [StringLength(150)]
    public string? GlobalOrderId { get; set; }

    public Guid? UseAllowanceMacroGuidId { get; set; }

    public bool? IsPrintedKdsOrderId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LoyaltyExtKey { get; set; }

    [Column("IsPostedToBSK")]
    public bool? IsPostedToBsk { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryPickupEstDate { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? WoltDriveOrderId { get; set; }

    [ForeignKey("DeliveryRoutingId")]
    [InverseProperty("OrdersNavigation")]
    public virtual DeliveryRouting? DeliveryRouting { get; set; }

    [ForeignKey("EndOfDayId")]
    [InverseProperty("Orders")]
    public virtual EndOfDay? EndOfDay { get; set; }

    [ForeignKey("MacroGuidId")]
    [InverseProperty("Orders")]
    public virtual HotelMacro? MacroGuid { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [InverseProperty("Order")]
    public virtual ICollection<OrderMonitoring> OrderMonitorings { get; set; } = new List<OrderMonitoring>();

    [InverseProperty("Order")]
    public virtual ICollection<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();

    [InverseProperty("Order")]
    public virtual ICollection<OrdersStaff> OrdersStaffs { get; set; } = new List<OrdersStaff>();

    [ForeignKey("PdaModuleId")]
    [InverseProperty("Orders")]
    public virtual PdaModule? PdaModule { get; set; }

    [ForeignKey("PosId")]
    [InverseProperty("Orders")]
    public virtual PosInfo? Pos { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("Orders")]
    public virtual Staff? Staff { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
