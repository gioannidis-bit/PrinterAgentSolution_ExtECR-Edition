using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ReportEntity")]
public partial class ReportEntity
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Url { get; set; } = null!;

    public byte[] Layout { get; set; } = null!;

    public int? OptimisticLockField { get; set; }

    [StringLength(100)]
    public string? ReportName { get; set; }

    [StringLength(50)]
    public string? Menu { get; set; }

    [StringLength(50)]
    public string? Submenu { get; set; }
}
