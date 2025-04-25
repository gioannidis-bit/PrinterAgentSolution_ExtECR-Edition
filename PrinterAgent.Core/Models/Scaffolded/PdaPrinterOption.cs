using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class PdaPrinterOption
{
    [Key]
    public long Id { get; set; }

    [StringLength(500)]
    public string? Row1 { get; set; }

    [StringLength(500)]
    public string? Row2 { get; set; }

    [StringLength(500)]
    public string? Row3 { get; set; }

    [StringLength(500)]
    public string? Row4 { get; set; }

    [StringLength(500)]
    public string? Row5 { get; set; }

    [StringLength(500)]
    public string? Row6 { get; set; }

    [StringLength(500)]
    public string? Row7 { get; set; }

    [StringLength(500)]
    public string? Row8 { get; set; }

    [StringLength(500)]
    public string? Row9 { get; set; }

    [StringLength(500)]
    public string? Row10 { get; set; }
}
