using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_Orders")]
public partial class DaOrder
{
    [Key]
    public long Id { get; set; }

    public long CustomerId { get; set; }

    public long StoreId { get; set; }

    [StringLength(50)]
    public string? StoreCode { get; set; }

    public long? GeoPolygonId { get; set; }

    public long? ShippingAddressId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EstBillingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BillingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EstTakeoutDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TakeoutDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    public int? Duration { get; set; }

    public long? BillingAddressId { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    [Column(TypeName = "money")]
    public decimal Discount { get; set; }

    [Column(TypeName = "money")]
    public decimal Total { get; set; }

    public short AccountType { get; set; }

    public short InvoiceType { get; set; }

    public short OrderType { get; set; }

    public short Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StatusChange { get; set; }

    [StringLength(1500)]
    public string? Remarks { get; set; }

    public long StoreOrderId { get; set; }

    public short IsSend { get; set; }

    public short Origin { get; set; }

    [Column(TypeName = "text")]
    public string? ExtObj { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal TotalVat { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal TotalTax { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal NetAmount { get; set; }

    public bool ItemsChanged { get; set; }

    public bool IsPaid { get; set; }

    public long? StoreOrderNo { get; set; }

    public int? PointsGain { get; set; }

    public int? PointsRedeem { get; set; }

    public bool IsDelay { get; set; }

    [StringLength(50)]
    public string? ExtId1 { get; set; }

    [StringLength(50)]
    public string? ExtId2 { get; set; }

    public int? Cover { get; set; }

    [Column(TypeName = "text")]
    public string? ErrorMessage { get; set; }

    [Column(TypeName = "text")]
    public string? ExtData { get; set; }

    [Column(TypeName = "text")]
    public string? LogicErrors { get; set; }

    [StringLength(500)]
    public string? DiscountRemark { get; set; }

    public long? Staffid { get; set; }

    [StringLength(50)]
    public string? AgentNo { get; set; }

    public string? PaymentId { get; set; }

    [StringLength(200)]
    public string? LoyaltyCode { get; set; }

    [StringLength(30)]
    public string? TelephoneNumber { get; set; }

    public string? Metadata { get; set; }

    public long? OrderNo { get; set; }

    public long? TableId { get; set; }

    [StringLength(50)]
    public string? ExtId3 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? ExtNum1 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? ExtNum2 { get; set; }

    public string? ExtString1 { get; set; }

    public string? ExtString2 { get; set; }

    public int? Mpehotel { get; set; }

    public int? RoomId { get; set; }

    [StringLength(50)]
    public string? RoomNo { get; set; }

    public int? ReservationId { get; set; }

    public long? StoreId2 { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("DaOrders")]
    public virtual DaCustomer Customer { get; set; } = null!;

    [InverseProperty("Order")]
    public virtual ICollection<DaCustomerMessage> DaCustomerMessages { get; set; } = new List<DaCustomerMessage>();

    [InverseProperty("Daorder")]
    public virtual ICollection<DaOrderDetail> DaOrderDetails { get; set; } = new List<DaOrderDetail>();

    [InverseProperty("OrderDa")]
    public virtual ICollection<DaOrderStatus> DaOrderStatuses { get; set; } = new List<DaOrderStatus>();

    [InverseProperty("Daorder")]
    public virtual ICollection<Loyalty> Loyalties { get; set; } = new List<Loyalty>();

    [ForeignKey("ShippingAddressId")]
    [InverseProperty("DaOrders")]
    public virtual DaAddress? ShippingAddress { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("DaOrders")]
    public virtual DaStore Store { get; set; } = null!;
}
