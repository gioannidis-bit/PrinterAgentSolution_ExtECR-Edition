using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class DiscountTypeResult
{
    [Key]
    public long Id { get; set; }

    public long? DiscountTypeId { get; set; }

    public bool? ItemDiscountFlag { get; set; }

    public string? DiscountItems { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ItemDiscount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ItemDiscountPercentage { get; set; }

    public bool? GroupDiscountFlag { get; set; }

    public string? GroupDiscounts { get; set; }

    public bool? OrderDiscountFlag { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? OrderDiscount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? OrderDiscountPercentage { get; set; }

    public bool? PriceListFlag { get; set; }

    public long? PriceList { get; set; }

    [ForeignKey("DiscountTypeId")]
    [InverseProperty("DiscountTypeResults")]
    public virtual DiscountType? DiscountType { get; set; }
}
