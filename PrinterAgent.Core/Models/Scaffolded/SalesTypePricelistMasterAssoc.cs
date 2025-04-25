using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("SalesType_PricelistMaster_Assoc")]
public partial class SalesTypePricelistMasterAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PricelistMasterId { get; set; }

    public long? SalesTypeId { get; set; }

    [ForeignKey("PricelistMasterId")]
    [InverseProperty("SalesTypePricelistMasterAssocs")]
    public virtual PricelistMaster? PricelistMaster { get; set; }

    [ForeignKey("SalesTypeId")]
    [InverseProperty("SalesTypePricelistMasterAssocs")]
    public virtual SalesType? SalesType { get; set; }
}
