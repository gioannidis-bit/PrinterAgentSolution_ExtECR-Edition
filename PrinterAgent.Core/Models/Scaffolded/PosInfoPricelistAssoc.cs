using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfo_Pricelist_Assoc")]
public partial class PosInfoPricelistAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public long? PricelistId { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PosInfoPricelistAssocs")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("PricelistId")]
    [InverseProperty("PosInfoPricelistAssocs")]
    public virtual Pricelist? Pricelist { get; set; }
}
