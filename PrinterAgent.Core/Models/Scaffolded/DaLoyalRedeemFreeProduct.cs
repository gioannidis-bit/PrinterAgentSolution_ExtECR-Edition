using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_LoyalRedeemFreeProduct")]
public partial class DaLoyalRedeemFreeProduct
{
    [Key]
    public long Id { get; set; }

    public int Points { get; set; }

    public long? ProductId { get; set; }

    [StringLength(500)]
    public string? ProductName { get; set; }

    public long? ProdCategoryId { get; set; }

    [StringLength(500)]
    public string? ProdCategoryName { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal Qnt { get; set; }

    [ForeignKey("ProdCategoryId")]
    [InverseProperty("DaLoyalRedeemFreeProducts")]
    public virtual ProductCategory? ProdCategory { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("DaLoyalRedeemFreeProducts")]
    public virtual Product? Product { get; set; }
}
