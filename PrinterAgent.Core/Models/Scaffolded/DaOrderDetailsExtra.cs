using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_OrderDetailsExtras")]
public partial class DaOrderDetailsExtra
{
    [Key]
    public long Id { get; set; }

    public long OrderDetailId { get; set; }

    public long ExtrasId { get; set; }

    [StringLength(150)]
    public string? ExtrasCode { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "decimal(12, 4)")]
    public decimal Qnt { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal Price { get; set; }

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

    [ForeignKey("OrderDetailId")]
    [InverseProperty("DaOrderDetailsExtras")]
    public virtual DaOrderDetail OrderDetail { get; set; } = null!;
}
