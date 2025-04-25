using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("SalesType")]
public partial class SalesType
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? Abbreviation { get; set; }

    public bool? IsDeleted { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [InverseProperty("SalesType")]
    public virtual ICollection<EnvironmentalFee> EnvironmentalFees { get; set; } = new List<EnvironmentalFee>();

    [InverseProperty("SalesType")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [InverseProperty("SalesType")]
    public virtual ICollection<SalesTypePricelistMasterAssoc> SalesTypePricelistMasterAssocs { get; set; } = new List<SalesTypePricelistMasterAssoc>();

    [InverseProperty("SalesType")]
    public virtual ICollection<TransferMapping> TransferMappings { get; set; } = new List<TransferMapping>();
}
