using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Region")]
public partial class Region
{
    [Key]
    public long Id { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    public string? BluePrintPath { get; set; }

    public int? MaxCapacity { get; set; }

    public long? PosInfoId { get; set; }

    public bool? IsLocker { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("Regions")]
    public virtual PosInfo? PosInfo { get; set; }

    [InverseProperty("Region")]
    public virtual ICollection<PosInfoRegionAssoc> PosInfoRegionAssocs { get; set; } = new List<PosInfoRegionAssoc>();

    [InverseProperty("Region")]
    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
