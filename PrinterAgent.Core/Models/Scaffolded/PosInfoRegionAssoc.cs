using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfo_Region_Assoc")]
public partial class PosInfoRegionAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public long? RegionId { get; set; }

    [StringLength(300)]
    public string? Description { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PosInfoRegionAssocs")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("RegionId")]
    [InverseProperty("PosInfoRegionAssocs")]
    public virtual Region? Region { get; set; }
}
