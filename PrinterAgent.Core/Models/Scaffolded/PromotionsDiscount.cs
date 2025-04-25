using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Promotions_Discounts")]
public partial class PromotionsDiscount
{
    [Key]
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    public long? ItemId { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? ItemQuantity { get; set; }

    public bool? ItemIsProduct { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [ForeignKey("HeaderId")]
    [InverseProperty("PromotionsDiscounts")]
    public virtual PromotionsHeader? Header { get; set; }
}
