using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_GeoPolygonsDetails")]
public partial class DaGeoPolygonsDetail
{
    [Key]
    public long Id { get; set; }

    public long PolygId { get; set; }

    public double Latitude { get; set; }

    public double Longtitude { get; set; }

    [ForeignKey("PolygId")]
    [InverseProperty("DaGeoPolygonsDetails")]
    public virtual DaGeoPolygon Polyg { get; set; } = null!;
}
