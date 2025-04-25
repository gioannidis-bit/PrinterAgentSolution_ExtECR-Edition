using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Version")]
public partial class Version
{
    [Key]
    [Column("Version")]
    [StringLength(50)]
    public string Version1 { get; set; } = null!;

    [StringLength(50)]
    public string? ReportVersion { get; set; }
}
