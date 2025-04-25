using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ForexService")]
public partial class ForexService
{
    [Key]
    public long Id { get; set; }

    [StringLength(20)]
    public string? CurFrom { get; set; }

    [StringLength(20)]
    public string? CurTo { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Rate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }
}
