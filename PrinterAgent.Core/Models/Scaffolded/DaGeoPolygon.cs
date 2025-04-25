using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_GeoPolygons")]
public partial class DaGeoPolygon
{
    [Key]
    public long Id { get; set; }

    public long? StoreId { get; set; }

    [StringLength(200)]
    public string Name { get; set; } = null!;

    [StringLength(1500)]
    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    [InverseProperty("Polyg")]
    public virtual ICollection<DaGeoPolygonsDetail> DaGeoPolygonsDetails { get; set; } = new List<DaGeoPolygonsDetail>();

    [ForeignKey("StoreId")]
    [InverseProperty("DaGeoPolygons")]
    public virtual DaStore? Store { get; set; }
}
