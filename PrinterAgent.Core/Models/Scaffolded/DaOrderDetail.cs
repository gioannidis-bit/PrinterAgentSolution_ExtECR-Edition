using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_OrderDetails")]
public partial class DaOrderDetail
{
    [Key]
    public long Id { get; set; }

    [Column("DAOrderId")]
    public long DaorderId { get; set; }

    public long ProductId { get; set; }

    [StringLength(150)]
    public string? ProductCode { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = null!;

    public long PriceListId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal Qnt { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal Discount { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal Total { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal TotalVat { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal RateVat { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal RateTax { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal TotalTax { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal NetAmount { get; set; }

    [StringLength(500)]
    public string? ItemRemark { get; set; }

    public short? OtherDiscount { get; set; }

    [InverseProperty("OrderDetail")]
    public virtual ICollection<DaOrderDetailsExtra> DaOrderDetailsExtras { get; set; } = new List<DaOrderDetailsExtra>();

    [ForeignKey("DaorderId")]
    [InverseProperty("DaOrderDetails")]
    public virtual DaOrder Daorder { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("DaOrderDetails")]
    public virtual Product Product { get; set; } = null!;
}
