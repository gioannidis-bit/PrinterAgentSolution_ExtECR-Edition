using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Promotions_Pricelists")]
public partial class PromotionsPricelist
{
    [Key]
    public long Id { get; set; }

    public long? PricelistId { get; set; }

    [ForeignKey("PricelistId")]
    [InverseProperty("PromotionsPricelists")]
    public virtual Pricelist? Pricelist { get; set; }
}
