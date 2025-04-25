using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("OrderDetail")]
public partial class OrderDetail
{
    [Key]
    public long Id { get; set; }

    public long? OrderId { get; set; }

    public long? ProductId { get; set; }

    public long? KitchenId { get; set; }

    public long? KdsId { get; set; }

    public int? PreparationTime { get; set; }

    public long? TableId { get; set; }

    public byte? Status { get; set; }

    [Column("StatusTS", TypeName = "datetime")]
    public DateTime? StatusTs { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    public long? PriceListDetailId { get; set; }

    public double? Qty { get; set; }

    public long? SalesTypeId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Discount { get; set; }

    public byte? PaidStatus { get; set; }

    public long? TransactionId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? TotalAfterDiscount { get; set; }

    public long? GuestId { get; set; }

    public int? Couver { get; set; }

    public Guid? Guid { get; set; }

    public bool? IsDeleted { get; set; }

    public double? PendingQty { get; set; }

    public short? OtherDiscount { get; set; }

    public int? KitchenStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KitchenStatusTs { get; set; }

    public long? LoginStaffId { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("OrderDetails")]
    public virtual Guest? Guest { get; set; }

    [ForeignKey("LoginStaffId")]
    [InverseProperty("OrderDetails")]
    public virtual Staff? LoginStaff { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderDetails")]
    public virtual Order? Order { get; set; }

    [InverseProperty("OrderDetail")]
    public virtual ICollection<OrderDetailIgredient> OrderDetailIgredients { get; set; } = new List<OrderDetailIgredient>();

    [InverseProperty("OrderDetail")]
    public virtual ICollection<OrderDetailInvoice> OrderDetailInvoices { get; set; } = new List<OrderDetailInvoice>();

    [InverseProperty("OrderDetail")]
    public virtual ICollection<OrderDetailVatAnal> OrderDetailVatAnals { get; set; } = new List<OrderDetailVatAnal>();

    [ForeignKey("PriceListDetailId")]
    [InverseProperty("OrderDetails")]
    public virtual PricelistDetail? PriceListDetail { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("OrderDetails")]
    public virtual Product? Product { get; set; }

    [ForeignKey("SalesTypeId")]
    [InverseProperty("OrderDetails")]
    public virtual SalesType? SalesType { get; set; }

    [ForeignKey("TableId")]
    [InverseProperty("OrderDetails")]
    public virtual Table? Table { get; set; }

    [InverseProperty("OrderDetail")]
    public virtual ICollection<TablePaySuggestion> TablePaySuggestions { get; set; } = new List<TablePaySuggestion>();

    [ForeignKey("TransactionId")]
    [InverseProperty("OrderDetails")]
    public virtual Transaction? Transaction { get; set; }
}
