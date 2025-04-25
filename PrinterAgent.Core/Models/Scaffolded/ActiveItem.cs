using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ActiveItem
{
    [Column("code")]
    [StringLength(150)]
    public string? Code { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column("price", TypeName = "money")]
    public decimal? Price { get; set; }

    [Column("vat")]
    public double? Vat { get; set; }

    [StringLength(150)]
    public string? Category { get; set; }
}
