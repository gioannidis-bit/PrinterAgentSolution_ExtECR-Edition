using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PricelistMaster")]
public partial class PricelistMaster
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public byte? Status { get; set; }

    public bool? Active { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [InverseProperty("PricelistMaster")]
    public virtual ICollection<Pricelist> Pricelists { get; set; } = new List<Pricelist>();

    [InverseProperty("PricelistMaster")]
    public virtual ICollection<SalesTypePricelistMasterAssoc> SalesTypePricelistMasterAssocs { get; set; } = new List<SalesTypePricelistMasterAssoc>();
}
