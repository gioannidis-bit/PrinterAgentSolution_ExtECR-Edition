using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Discount")]
public partial class Discount
{
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// 0 : Draxmiki - 1 : Posostiaia
    /// </summary>
    public byte? Type { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Amount { get; set; }

    public bool? Status { get; set; }

    public int? Sort { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public bool? IsHidden { get; set; }
}
