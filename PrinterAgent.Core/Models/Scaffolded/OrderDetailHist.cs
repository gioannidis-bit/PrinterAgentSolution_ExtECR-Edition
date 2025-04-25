using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("OrderDetail_Hist")]
public partial class OrderDetailHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

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

    public int? KitchenStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KitchenStatusTs { get; set; }

    public long? LoginStaffId { get; set; }

    public short? OtherDiscount { get; set; }
}
