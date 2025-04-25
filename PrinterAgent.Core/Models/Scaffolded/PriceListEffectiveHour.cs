using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PriceList_EffectiveHours")]
public partial class PriceListEffectiveHour
{
    [Key]
    public long Id { get; set; }

    public long? PricelistId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [ForeignKey("PricelistId")]
    [InverseProperty("PriceListEffectiveHours")]
    public virtual Pricelist? Pricelist { get; set; }
}
