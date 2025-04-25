using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class CoverWithMeal
{
    public int? CoverBreakfast { get; set; }

    public int? CoverNoon { get; set; }

    public int? CoverNight { get; set; }

    public int? ConsumedMeals { get; set; }

    [Column("FODay", TypeName = "datetime")]
    public DateTime? Foday { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [StringLength(250)]
    public string? PosDescription { get; set; }
}
