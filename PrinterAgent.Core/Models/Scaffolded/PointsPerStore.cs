using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class PointsPerStore
{
    [Column("PointsPerStore")]
    public int? PointsPerStore1 { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    public int? CustomerSum { get; set; }
}
