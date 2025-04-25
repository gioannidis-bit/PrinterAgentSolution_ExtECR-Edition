using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("RegionLockerProduct")]
public partial class RegionLockerProduct
{
    [Key]
    public long Id { get; set; }

    public long? ProductId { get; set; }

    public long? PriceListId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [Column(TypeName = "money")]
    public decimal? Discount { get; set; }

    [StringLength(150)]
    public string? SalesDescription { get; set; }

    public long? ReturnPaymentpId { get; set; }

    public long? PaymentId { get; set; }

    public long? SaleId { get; set; }

    public long? PosInfoId { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("RegionLockerProducts")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("PriceListId")]
    [InverseProperty("RegionLockerProducts")]
    public virtual Pricelist? PriceList { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("RegionLockerProducts")]
    public virtual Product? Product { get; set; }
}
