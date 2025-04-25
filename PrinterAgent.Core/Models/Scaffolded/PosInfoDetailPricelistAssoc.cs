using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfoDetail_Pricelist_Assoc")]
public partial class PosInfoDetailPricelistAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoDetailId { get; set; }

    public long? PricelistId { get; set; }

    [ForeignKey("PosInfoDetailId")]
    [InverseProperty("PosInfoDetailPricelistAssocs")]
    public virtual PosInfoDetail? PosInfoDetail { get; set; }

    [ForeignKey("PricelistId")]
    [InverseProperty("PosInfoDetailPricelistAssocs")]
    public virtual Pricelist? Pricelist { get; set; }
}
