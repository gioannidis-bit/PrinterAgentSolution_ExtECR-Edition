using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class Baguest
{
    [Column("invoiceid")]
    public long? Invoiceid { get; set; }

    [StringLength(150)]
    public string? Room { get; set; }

    [Column("nationality")]
    [StringLength(150)]
    public string? Nationality { get; set; }

    [Column("age")]
    public int? Age { get; set; }
}
