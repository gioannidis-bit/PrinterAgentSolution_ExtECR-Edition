using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("EnvironmentalFee")]
public partial class EnvironmentalFee
{
    [Key]
    public long Id { get; set; }

    public long? SalesTypeId { get; set; }

    public long? ProductId { get; set; }

    public long? EnvironmentalFeeProductId { get; set; }

    public int? UnitEnvironmentalFee { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("EnvironmentalFees")]
    public virtual Product? Product { get; set; }

    [ForeignKey("SalesTypeId")]
    [InverseProperty("EnvironmentalFees")]
    public virtual SalesType? SalesType { get; set; }
}
