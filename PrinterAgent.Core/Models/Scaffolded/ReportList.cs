using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ReportList")]
public partial class ReportList
{
    [Key]
    public long Id { get; set; }

    [StringLength(350)]
    public string? ReportName { get; set; }

    public int? ReportType { get; set; }

    public string? ReportJson { get; set; }

    public bool? AppearsInMenu { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Datemodified { get; set; }

    [StringLength(50)]
    public string? Version { get; set; }

    [InverseProperty("ReportList")]
    public virtual ICollection<StatisticsMenu> StatisticsMenus { get; set; } = new List<StatisticsMenu>();
}
